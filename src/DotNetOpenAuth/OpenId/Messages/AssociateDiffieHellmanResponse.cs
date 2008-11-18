﻿//-----------------------------------------------------------------------
// <copyright file="AssociateDiffieHellmanResponse.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OpenId.Messages {
	using System;
	using System.Security.Cryptography;
	using DotNetOpenAuth.Messaging;
	using DotNetOpenAuth.Messaging.Reflection;
	using Org.Mentalis.Security.Cryptography;

	/// <summary>
	/// The successful Diffie-Hellman association response message.
	/// </summary>
	/// <remarks>
	/// Association response messages are described in OpenID 2.0 section 8.2.  This type covers section 8.2.3.
	/// </remarks>
	internal class AssociateDiffieHellmanResponse : AssociateSuccessfulResponse {
		/// <summary>
		/// Gets or sets the Provider's Diffie-Hellman public key. 
		/// </summary>
		/// <value>btwoc(g ^ xb mod p)</value>
		[MessagePart("dh_server_public", IsRequired = true, AllowEmpty = false)]
		internal byte[] DiffieHellmanServerPublic { get; set; }

		/// <summary>
		/// Gets or sets the MAC key (shared secret), encrypted with the secret Diffie-Hellman value.
		/// </summary>
		/// <value>H(btwoc(g ^ (xa * xb) mod p)) XOR MAC key. H is either "SHA1" or "SHA256" depending on the session type. </value>
		[MessagePart("enc_mac_key", IsRequired = true, AllowEmpty = false)]
		internal byte[] EncodedMacKey { get; set; }

		/// <summary>
		/// Called to create the Association based on a request previously given by the Relying Party.
		/// </summary>
		/// <param name="request">The prior request for an association.</param>
		/// <returns>The created association.</returns>
		/// <remarks>
		/// 	<para>The response message is updated to include the details of the created association by this method,
		/// but the resulting association is <i>not</i> added to the association store and must be done by the caller.</para>
		/// 	<para>This method is called by both the Provider and the Relying Party, but actually performs
		/// quite different operations in either scenario.</para>
		/// </remarks>
		protected internal override Association CreateAssociation(AssociateRequest request) {
			ErrorUtilities.VerifyArgumentNotNull(request, "request");
			ErrorUtilities.VerifyArgument(request is AssociateDiffieHellmanRequest, "request");

			return this.CreateAssociation((AssociateDiffieHellmanRequest)request);
		}

		/// <summary>
		/// Called to create the Association based on a request previously given by the Relying Party.
		/// </summary>
		/// <param name="request">The request for an association.</param>
		/// <returns>The created association.</returns>
		/// <remarks>
		/// <para>The response message is updated to include the details of the created association by this method, 
		/// but the resulting association is <i>not</i> added to the association store and must be done by the caller.</para>
		/// <para>This method is called by both the Provider and the Relying Party, but actually performs
		/// quite different operations in either scenario.</para>
		/// </remarks>
		private Association CreateAssociation(AssociateDiffieHellmanRequest request) {
			// If the encoded mac key is already set, then this is an incoming message at the Relying Party.
			if (this.EncodedMacKey == null) {
				return this.CreateAssociationAtProvider(request);
			} else {
				return this.CreateAssociationAtRelyingParty(request);
			}
		}

		/// <summary>
		/// Creates the association at relying party side after the association response has been received.
		/// </summary>
		/// <param name="request">The original association request that was already sent and responded to.</param>
		/// <returns>The newly created association.</returns>
		/// <remarks>
		/// The resulting association is <i>not</i> added to the association store and must be done by the caller.
		/// </remarks>
		private Association CreateAssociationAtRelyingParty(AssociateDiffieHellmanRequest request) {
			ErrorUtilities.VerifyArgumentNotNull(request, "request");

			HashAlgorithm hasher = DiffieHellmanUtilities.Lookup(Protocol, this.SessionType);
			byte[] associationSecret = DiffieHellmanUtilities.SHAHashXorSecret(hasher, request.Algorithm, this.DiffieHellmanServerPublic, this.EncodedMacKey);

			Association association = HmacShaAssociation.Create(Protocol, this.AssociationType, this.AssociationHandle, associationSecret, TimeSpan.FromSeconds(this.ExpiresIn));
			return association;
		}

		/// <summary>
		/// Creates the association at the provider side after the association request has been received.
		/// </summary>
		/// <param name="request">The association request.</param>
		/// <returns>The newly created association.</returns>
		/// <remarks>
		/// The response message is updated to include the details of the created association by this method, 
		/// but the resulting association is <i>not</i> added to the association store and must be done by the caller.
		/// </remarks>
		private Association CreateAssociationAtProvider(AssociateDiffieHellmanRequest request) {
			ErrorUtilities.VerifyArgumentNotNull(request, "request");

			this.SessionType = this.SessionType ?? request.SessionType;

			// Go ahead and create the association first, complete with its secret that we're about to share.
			Association association = HmacShaAssociation.Create(this.Protocol, this.AssociationType, AssociationRelyingPartyType.Smart);
			this.AssociationHandle = association.Handle;
			this.ExpiresIn = association.SecondsTillExpiration;

			// We now need to securely communicate the secret to the relying party using Diffie-Hellman.
			// We do this by performing a DH algorithm on the secret and setting a couple of properties
			// that will be transmitted to the Relying Party.  The RP will perform an inverse operation
			// using its part of a DH secret in order to decrypt the shared secret we just invented 
			// above when we created the association.
			DiffieHellman dh = new DiffieHellmanManaged(
				request.DiffieHellmanModulus ?? AssociateDiffieHellmanRequest.DefaultMod,
				request.DiffieHellmanGen ?? AssociateDiffieHellmanRequest.DefaultGen,
				AssociateDiffieHellmanRequest.DefaultX);
			HashAlgorithm hasher = DiffieHellmanUtilities.Lookup(this.Protocol, this.SessionType);
			this.DiffieHellmanServerPublic = DiffieHellmanUtilities.EnsurePositive(dh.CreateKeyExchange());
			this.EncodedMacKey = DiffieHellmanUtilities.SHAHashXorSecret(hasher, dh, request.DiffieHellmanConsumerPublic, association.SecretKey);

			return association;
		}
	}
}
