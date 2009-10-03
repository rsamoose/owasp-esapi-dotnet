﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Owasp.Esapi.Resources {
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
    internal class Errors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Errors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Owasp.Esapi.Resources.Errors", typeof(Errors).Assembly);
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
        ///   Looks up a localized string similar to No current user set.
        /// </summary>
        internal static string AccessControl_NoCurrentUser {
            get {
                return ResourceManager.GetString("AccessControl_NoCurrentUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to remove an access control rule that does not exist..
        /// </summary>
        internal static string AccessControl_RemoveInvalidRule {
            get {
                return ResourceManager.GetString("AccessControl_RemoveInvalidRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request for invalid indirect reference.
        /// </summary>
        internal static string AccessReferenceMap_AccessDeniedLog {
            get {
                return ResourceManager.GetString("AccessReferenceMap_AccessDeniedLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access denied.
        /// </summary>
        internal static string AccessReferenceMap_AccessDeniedUser {
            get {
                return ResourceManager.GetString("AccessReferenceMap_AccessDeniedUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to add an access control rule that already exists..
        /// </summary>
        internal static string AcessControl_AddDuplicateRule {
            get {
                return ResourceManager.GetString("AcessControl_AddDuplicateRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input validation failure.
        /// </summary>
        internal static string Encoder_InputValidationFailure {
            get {
                return ResourceManager.GetString("Encoder_InputValidationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mixed encoding ({0}x) detected.
        /// </summary>
        internal static string Encoder_MixedEncoding1 {
            get {
                return ResourceManager.GetString("Encoder_MixedEncoding1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple ({0}x) encoding detected.
        /// </summary>
        internal static string Encoder_MultipleEncoding1 {
            get {
                return ResourceManager.GetString("Encoder_MultipleEncoding1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple ({0}x) and mixed encoding ({1}x) detected.
        /// </summary>
        internal static string Encoder_MultipleMixedEncoding2 {
            get {
                return ResourceManager.GetString("Encoder_MultipleMixedEncoding2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to decrypt : {0}.
        /// </summary>
        internal static string Encryptor_DecryptFailed1 {
            get {
                return ResourceManager.GetString("Encryptor_DecryptFailed1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Decryption failed.
        /// </summary>
        internal static string Encryptor_DecryptionFailure {
            get {
                return ResourceManager.GetString("Encryptor_DecryptionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encryption failure.
        /// </summary>
        internal static string Encryptor_EncryptionFailure {
            get {
                return ResourceManager.GetString("Encryptor_EncryptionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error creating encryptor.
        /// </summary>
        internal static string Encryptor_EncryptorCreateFailed {
            get {
                return ResourceManager.GetString("Encryptor_EncryptorCreateFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid seal.
        /// </summary>
        internal static string Encryptor_InvalidSeal {
            get {
                return ResourceManager.GetString("Encryptor_InvalidSeal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seal did not decrypt properly.
        /// </summary>
        internal static string Encryptor_SealDecryptFailed {
            get {
                return ResourceManager.GetString("Encryptor_SealDecryptFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seal expiration date has expired.
        /// </summary>
        internal static string Encryptor_SealExpired {
            get {
                return ResourceManager.GetString("Encryptor_SealExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seal did not contain properly formatted separator.
        /// </summary>
        internal static string Encryptor_SealWrongFormat {
            get {
                return ResourceManager.GetString("Encryptor_SealWrongFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t find has algorithm {0}.
        /// </summary>
        internal static string Encryptor_WrongHashAlg1 {
            get {
                return ResourceManager.GetString("Encryptor_WrongHashAlg1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication failed.
        /// </summary>
        internal static string HttpUtilities_AuthFailed {
            get {
                return ResourceManager.GetString("HttpUtilities_AuthFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Possibly forged HTTP request without proper CSRF token detected.
        /// </summary>
        internal static string HttpUtilities_CsrfCheckFailed {
            get {
                return ResourceManager.GetString("HttpUtilities_CsrfCheckFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Insecure method.
        /// </summary>
        internal static string HttpUtilities_InsecureMethod {
            get {
                return ResourceManager.GetString("HttpUtilities_InsecureMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Insecure protocol.
        /// </summary>
        internal static string HttpUtilities_InsecureProtocol {
            get {
                return ResourceManager.GetString("HttpUtilities_InsecureProtocol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Insecure request.
        /// </summary>
        internal static string HttpUtilities_InsecureRequest {
            get {
                return ResourceManager.GetString("HttpUtilities_InsecureRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Security event {0} received.
        /// </summary>
        internal static string InstrusionDetector_EventReceived1 {
            get {
                return ResourceManager.GetString("InstrusionDetector_EventReceived1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User exceeded quota of  {0}  per  {1} seconds for event  {2} ..
        /// </summary>
        internal static string InstrusionDetector_ExceededQuota3 {
            get {
                return ResourceManager.GetString("InstrusionDetector_ExceededQuota3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User exceeded quota of  {0}  per  {1} seconds for event  {2} . Taking action {3}.
        /// </summary>
        internal static string InstrusionDetector_ExceededQuota4 {
            get {
                return ResourceManager.GetString("InstrusionDetector_ExceededQuota4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid action name.
        /// </summary>
        internal static string InstrusionDetector_InvalidActionName {
            get {
                return ResourceManager.GetString("InstrusionDetector_InvalidActionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Threshold exceeded for {0}.
        /// </summary>
        internal static string InstrusionDetector_ThresholdExceeded1 {
            get {
                return ResourceManager.GetString("InstrusionDetector_ThresholdExceeded1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Action {0} is referenced.
        /// </summary>
        internal static string IntrusionDetector_ActionIsReferenced1 {
            get {
                return ResourceManager.GetString("IntrusionDetector_ActionIsReferenced1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required action {0} not found.
        /// </summary>
        internal static string IntrusionDetector_ActionNotFound1 {
            get {
                return ResourceManager.GetString("IntrusionDetector_ActionNotFound1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An action with this name already exists.
        /// </summary>
        internal static string IntrusionDetector_DuplicateActionName {
            get {
                return ResourceManager.GetString("IntrusionDetector_DuplicateActionName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Threshold exceeded.
        /// </summary>
        internal static string IntrusionDetector_ThresholdExceeded {
            get {
                return ResourceManager.GetString("IntrusionDetector_ThresholdExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown event name..
        /// </summary>
        internal static string IntrusionDetector_UnknownEventName {
            get {
                return ResourceManager.GetString("IntrusionDetector_UnknownEventName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid argument value.
        /// </summary>
        internal static string InvalidArgument {
            get {
                return ResourceManager.GetString("InvalidArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t find random algorithm {1}.
        /// </summary>
        internal static string Randomizer_AlgCreateFailed1 {
            get {
                return ResourceManager.GetString("Randomizer_AlgCreateFailed1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Randomizer failure.
        /// </summary>
        internal static string Randomizer_Failure {
            get {
                return ResourceManager.GetString("Randomizer_Failure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum request count exceeded.
        /// </summary>
        internal static string RequestThrottleRule_MaximumExceeded {
            get {
                return ResourceManager.GetString("RequestThrottleRule_MaximumExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session not initialized.
        /// </summary>
        internal static string RequestThrottleRule_SessionRequired {
            get {
                return ResourceManager.GetString("RequestThrottleRule_SessionRequired", resourceCulture);
            }
        }
    }
}
