﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOpenAuth.Messaging {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MessagingStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessagingStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOpenAuth.Messaging.MessagingStrings", typeof(MessagingStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument&apos;s {0}.{1} property is required but is empty or null..
        /// </summary>
        internal static string ArgumentPropertyMissing {
            get {
                return ResourceManager.GetString("ArgumentPropertyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HttpContext.Current is null.  There must be an ASP.NET request in process for this operation to succeed..
        /// </summary>
        internal static string CurrentHttpContextRequired {
            get {
                return ResourceManager.GetString("CurrentHttpContextRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DataContractSerializer could not be initialized on message type {0}.  Is it missing a [DataContract] attribute?.
        /// </summary>
        internal static string DataContractMissingFromMessageType {
            get {
                return ResourceManager.GetString("DataContractMissingFromMessageType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DataContractSerializer could not be initialized on message type {0} because the DataContractAttribute.Namespace property is not set..
        /// </summary>
        internal static string DataContractMissingNamespace {
            get {
                return ResourceManager.GetString("DataContractMissingNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An instance of type {0} was expected, but received unexpected derived type {1}..
        /// </summary>
        internal static string DerivedTypeNotExpected {
            get {
                return ResourceManager.GetString("DerivedTypeNotExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directed message&apos;s Recipient property must not be null..
        /// </summary>
        internal static string DirectedMessageMissingRecipient {
            get {
                return ResourceManager.GetString("DirectedMessageMissingRecipient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while deserializing message {0}..
        /// </summary>
        internal static string ErrorDeserializingMessage {
            get {
                return ResourceManager.GetString("ErrorDeserializingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occurred while sending a direct message or getting the response..
        /// </summary>
        internal static string ErrorInRequestReplyMessage {
            get {
                return ResourceManager.GetString("ErrorInRequestReplyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This exception was not constructed with a root request message that caused it..
        /// </summary>
        internal static string ExceptionNotConstructedForTransit {
            get {
                return ResourceManager.GetString("ExceptionNotConstructedForTransit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected {0} message but received no recognizable message..
        /// </summary>
        internal static string ExpectedMessageNotReceived {
            get {
                return ResourceManager.GetString("ExpectedMessageNotReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message expired at {0} and it is now {1}..
        /// </summary>
        internal static string ExpiredMessage {
            get {
                return ResourceManager.GetString("ExpiredMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one of GET or POST flags must be present..
        /// </summary>
        internal static string GetOrPostFlagsRequired {
            get {
                return ResourceManager.GetString("GetOrPostFlagsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method requires a current HttpContext.  Alternatively, use an overload of this method that allows you to pass in information without an HttpContext..
        /// </summary>
        internal static string HttpContextRequired {
            get {
                return ResourceManager.GetString("HttpContextRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Messages that indicate indirect transport must implement the {0} interface..
        /// </summary>
        internal static string IndirectMessagesMustImplementIDirectedProtocolMessage {
            get {
                return ResourceManager.GetString("IndirectMessagesMustImplementIDirectedProtocolMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The message required protections {0} but the channel could only apply {1}..
        /// </summary>
        internal static string InsufficentMessageProtection {
            get {
                return ResourceManager.GetString("InsufficentMessageProtection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some part(s) of the message have invalid values: {0}.
        /// </summary>
        internal static string InvalidMessageParts {
            get {
                return ResourceManager.GetString("InvalidMessageParts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The incoming message had an invalid or missing nonce..
        /// </summary>
        internal static string InvalidNonceReceived {
            get {
                return ResourceManager.GetString("InvalidNonceReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An item with the same key has already been added..
        /// </summary>
        internal static string KeyAlreadyExists {
            get {
                return ResourceManager.GetString("KeyAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for {0}.{1} on member {1} was expected to derive from {2} but was {3}..
        /// </summary>
        internal static string MessagePartEncoderWrongType {
            get {
                return ResourceManager.GetString("MessagePartEncoderWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while reading message &apos;{0}&apos; parameter &apos;{1}&apos; with value &apos;{2}&apos;..
        /// </summary>
        internal static string MessagePartReadFailure {
            get {
                return ResourceManager.GetString("MessagePartReadFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message parameter &apos;{0}&apos; with value &apos;{1}&apos; failed to base64 decode..
        /// </summary>
        internal static string MessagePartValueBase64DecodingFault {
            get {
                return ResourceManager.GetString("MessagePartValueBase64DecodingFault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while preparing message &apos;{0}&apos; parameter &apos;{1}&apos; for sending..
        /// </summary>
        internal static string MessagePartWriteFailure {
            get {
                return ResourceManager.GetString("MessagePartWriteFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A message response is already queued for sending in the response stream..
        /// </summary>
        internal static string QueuedMessageResponseAlreadyExists {
            get {
                return ResourceManager.GetString("QueuedMessageResponseAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This message has already been processed.  This could indicate a replay attack in progress..
        /// </summary>
        internal static string ReplayAttackDetected {
            get {
                return ResourceManager.GetString("ReplayAttackDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This channel does not support replay protection..
        /// </summary>
        internal static string ReplayProtectionNotSupported {
            get {
                return ResourceManager.GetString("ReplayProtectionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following required non-empty parameters were empty in the {0} message: {1}.
        /// </summary>
        internal static string RequiredNonEmptyParameterWasEmpty {
            get {
                return ResourceManager.GetString("RequiredNonEmptyParameterWasEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following required parameters were missing from the {0} message: {1}.
        /// </summary>
        internal static string RequiredParametersMissing {
            get {
                return ResourceManager.GetString("RequiredParametersMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The binding element offering the {0} protection requires other protection that is not provided..
        /// </summary>
        internal static string RequiredProtectionMissing {
            get {
                return ResourceManager.GetString("RequiredProtectionMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The list is empty..
        /// </summary>
        internal static string SequenceContainsNoElements {
            get {
                return ResourceManager.GetString("SequenceContainsNoElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The list contains a null element..
        /// </summary>
        internal static string SequenceContainsNullElement {
            get {
                return ResourceManager.GetString("SequenceContainsNullElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message signature was incorrect..
        /// </summary>
        internal static string SignatureInvalid {
            get {
                return ResourceManager.GetString("SignatureInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This channel does not support signing messages.  To support signing messages, a derived Channel type must override the Sign and IsSignatureValid methods..
        /// </summary>
        internal static string SigningNotSupported {
            get {
                return ResourceManager.GetString("SigningNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stream&apos;s CanRead property returned false..
        /// </summary>
        internal static string StreamUnreadable {
            get {
                return ResourceManager.GetString("StreamUnreadable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stream&apos;s CanWrite property returned false..
        /// </summary>
        internal static string StreamUnwritable {
            get {
                return ResourceManager.GetString("StreamUnwritable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected at most 1 binding element offering the {0} protection, but found {1}..
        /// </summary>
        internal static string TooManyBindingsOfferingSameProtection {
            get {
                return ResourceManager.GetString("TooManyBindingsOfferingSameProtection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The array must not be empty..
        /// </summary>
        internal static string UnexpectedEmptyArray {
            get {
                return ResourceManager.GetString("UnexpectedEmptyArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The empty string is not allowed..
        /// </summary>
        internal static string UnexpectedEmptyString {
            get {
                return ResourceManager.GetString("UnexpectedEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message parameter &apos;{0}&apos; had unexpected value &apos;{1}&apos;..
        /// </summary>
        internal static string UnexpectedMessagePartValue {
            get {
                return ResourceManager.GetString("UnexpectedMessagePartValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected message {0} parameter &apos;{1}&apos; to have value &apos;{2}&apos; but had &apos;{3}&apos; instead..
        /// </summary>
        internal static string UnexpectedMessagePartValueForConstant {
            get {
                return ResourceManager.GetString("UnexpectedMessagePartValueForConstant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected message {0} but received {1} instead..
        /// </summary>
        internal static string UnexpectedMessageReceived {
            get {
                return ResourceManager.GetString("UnexpectedMessageReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected message type received..
        /// </summary>
        internal static string UnexpectedMessageReceivedOfMany {
            get {
                return ResourceManager.GetString("UnexpectedMessageReceivedOfMany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} or a derived type was expected, but {1} was given..
        /// </summary>
        internal static string UnexpectedType {
            get {
                return ResourceManager.GetString("UnexpectedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} property has unrecognized value {1}..
        /// </summary>
        internal static string UnrecognizedEnumValue {
            get {
                return ResourceManager.GetString("UnrecognizedEnumValue", resourceCulture);
            }
        }
    }
}
