﻿//-----------------------------------------------------------------------
// <copyright file="NoDiscoveryIdentifier.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OpenId {
	using System;
	using System.Collections.Generic;
	using DotNetOpenAuth.Messaging;
	using DotNetOpenAuth.OpenId.RelyingParty;

	/// <summary>
	/// Wraps an existing Identifier and prevents it from performing discovery.
	/// </summary>
	internal class NoDiscoveryIdentifier : Identifier {
		/// <summary>
		/// The wrapped identifier.
		/// </summary>
		private Identifier wrappedIdentifier;

		/// <summary>
		/// Initializes a new instance of the <see cref="NoDiscoveryIdentifier"/> class.
		/// </summary>
		/// <param name="wrappedIdentifier">The ordinary Identifier whose discovery is being masked.</param>
		internal NoDiscoveryIdentifier(Identifier wrappedIdentifier)
			: base(false) {
			ErrorUtilities.VerifyArgumentNotNull(wrappedIdentifier, "wrappedIdentifier");

			this.wrappedIdentifier = wrappedIdentifier;
		}

#if DISCOVERY // TODO: Add discovery and then re-enable this code block
		internal override IEnumerable<ServiceEndpoint> Discover() {
			return new ServiceEndpoint[0];
		}
#endif
		/// <summary>
		/// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
		/// </returns>
		public override string ToString() {
			return this.wrappedIdentifier.ToString();
		}

		/// <summary>
		/// Tests equality between two <see cref="Identifier"/>s.
		/// </summary>
		/// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.</param>
		/// <returns>
		/// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		/// <exception cref="T:System.NullReferenceException">
		/// The <paramref name="obj"/> parameter is null.
		/// </exception>
		public override bool Equals(object obj) {
			return this.wrappedIdentifier.Equals(obj);
		}

		/// <summary>
		/// Gets the hash code for an <see cref="Identifier"/> for storage in a hashtable.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode() {
			return this.wrappedIdentifier.GetHashCode();
		}

		/// <summary>
		/// Returns an <see cref="Identifier"/> that has no URI fragment.
		/// Quietly returns the original <see cref="Identifier"/> if it is not
		/// a <see cref="UriIdentifier"/> or no fragment exists.
		/// </summary>
		/// <returns>
		/// A new <see cref="Identifier"/> instance if there was a
		/// fragment to remove, otherwise this same instance..
		/// </returns>
		internal override Identifier TrimFragment() {
			return new NoDiscoveryIdentifier(this.wrappedIdentifier.TrimFragment());
		}

		/// <summary>
		/// Converts a given identifier to its secure equivalent.
		/// UriIdentifiers originally created with an implied HTTP scheme change to HTTPS.
		/// Discovery is made to require SSL for the entire resolution process.
		/// </summary>
		/// <param name="secureIdentifier">The newly created secure identifier.
		/// If the conversion fails, <paramref name="secureIdentifier"/> retains
		/// <i>this</i> identifiers identity, but will never discover any endpoints.</param>
		/// <returns>
		/// True if the secure conversion was successful.
		/// False if the Identifier was originally created with an explicit HTTP scheme.
		/// </returns>
		internal override bool TryRequireSsl(out Identifier secureIdentifier) {
			return this.wrappedIdentifier.TryRequireSsl(out secureIdentifier);
		}
	}
}
