﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ichigocake.common.Resources {
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
    public class ErrorStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ichigocake.common.Resources.ErrorStrings", typeof(ErrorStrings).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adres bilgisi gereklidir..
        /// </summary>
        public static string AddressRequired {
            get {
                return ResourceManager.GetString("AddressRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E-Posta Adresi gereklidir..
        /// </summary>
        public static string EmailRequired {
            get {
                return ResourceManager.GetString("EmailRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dosya Yüklenirken Hata Oluştu.
        /// </summary>
        public static string FileUploadError {
            get {
                return ResourceManager.GetString("FileUploadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Geçersiz e-posta adresi..
        /// </summary>
        public static string InvalidEmail {
            get {
                return ResourceManager.GetString("InvalidEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lütfen isminizi ve soyisminizi girin..
        /// </summary>
        public static string NameAndSurnameInvalid {
            get {
                return ResourceManager.GetString("NameAndSurnameInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to İsim ve Soyisim alanı gereklidir..
        /// </summary>
        public static string NameAndSurnameRequired {
            get {
                return ResourceManager.GetString("NameAndSurnameRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kişi Sayısı Gereklidir..
        /// </summary>
        public static string PersonAmountRequired {
            get {
                return ResourceManager.GetString("PersonAmountRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Telefon numarası gereklidir..
        /// </summary>
        public static string PhoneNumberRequired {
            get {
                return ResourceManager.GetString("PhoneNumberRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Etkinlik tarihi ve saati gereklidir..
        /// </summary>
        public static string RequestedDateTimeRequired {
            get {
                return ResourceManager.GetString("RequestedDateTimeRequired", resourceCulture);
            }
        }
    }
}
