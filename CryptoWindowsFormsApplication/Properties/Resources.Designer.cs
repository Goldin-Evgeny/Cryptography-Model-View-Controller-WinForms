﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CryptoWindowsFormsApplication.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CryptoWindowsFormsApplication.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Please choose file to .
        /// </summary>
        internal static string askForFileDirectory {
            get {
                return ResourceManager.GetString("askForFileDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please choose key file..
        /// </summary>
        internal static string askForKeyFile {
            get {
                return ResourceManager.GetString("askForKeyFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad key file!.
        /// </summary>
        internal static string badKeyFile {
            get {
                return ResourceManager.GetString("badKeyFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose file to encrypt.
        /// </summary>
        internal static string chooseFileToEncrypt {
            get {
                return ResourceManager.GetString("chooseFileToEncrypt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to decrypt..
        /// </summary>
        internal static string decrypt {
            get {
                return ResourceManager.GetString("decrypt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Our decryption system can decrypt any encrypted-by-us
        ///text file provided unchanged and untouched
        ///encrypted file and key file..
        /// </summary>
        internal static string decryptionDescription {
            get {
                return ResourceManager.GetString("decryptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to encrypt..
        /// </summary>
        internal static string encrypt {
            get {
                return ResourceManager.GetString("encrypt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Decryption proccess is done.
        ///The decrypted file has been saved to {0} directory..
        /// </summary>
        internal static string eventDecryptionEnded {
            get {
                return ResourceManager.GetString("eventDecryptionEnded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begun decrypting file..
        /// </summary>
        internal static string eventDecryptionStarted {
            get {
                return ResourceManager.GetString("eventDecryptionStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encryption proccess is done.
        ///The encrypted file has been saved to {0} directory,
        ///and the key file to {1} directory..
        /// </summary>
        internal static string eventEncryptionEnded {
            get {
                return ResourceManager.GetString("eventEncryptionEnded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begun encrypting file..
        /// </summary>
        internal static string eventEncryptionStarted {
            get {
                return ResourceManager.GetString("eventEncryptionStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hello and welcome to Crypto!.
        /// </summary>
        internal static string greeting {
            get {
                return ResourceManager.GetString("greeting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is some shiftmultiply cryptography,
        ///with which I wouldn&apos;t recommend encryption files..
        /// </summary>
        internal static string shiftmultiplyCryptographyDescription {
            get {
                return ResourceManager.GetString("shiftmultiplyCryptographyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This is some shiftup cryptography,
        ///with which I wouldn&apos;t recommend encryption files..
        /// </summary>
        internal static string shiftupCryptographyDescription {
            get {
                return ResourceManager.GetString("shiftupCryptographyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It took {0:c} to complete the operation successfully..
        /// </summary>
        internal static string timeOperationTook {
            get {
                return ResourceManager.GetString("timeOperationTook", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to txt files (*.txt)|*.txt.
        /// </summary>
        internal static string txtFileTypeFilter {
            get {
                return ResourceManager.GetString("txtFileTypeFilter", resourceCulture);
            }
        }
    }
}