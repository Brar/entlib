﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Validation Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Properties {
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
    public class Resources_Desktop {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources_Desktop() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Validation.Properties.Resources.Desktop", typeof(Resources_Desktop).Assembly);
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
        ///   Looks up a localized string similar to Enterprise Library Validation Application Block.
        /// </summary>
        public static string BlockName {
            get {
                return ResourceManager.GetString("BlockName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Errors reading configuration for Enterprise Library Validation Application Block.
        /// </summary>
        public static string ConfigurationErrorMessage {
            get {
                return ResourceManager.GetString("ConfigurationErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied value could not be converted to the target property type..
        /// </summary>
        public static string ErrorCannotPerfomDefaultConversion {
            get {
                return ResourceManager.GetString("ErrorCannotPerfomDefaultConversion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempted to retrieve value from instance of wrong type..
        /// </summary>
        public static string ExceptionAttemptedValueAccessForInstanceOfInvalidType {
            get {
                return ResourceManager.GetString("ExceptionAttemptedValueAccessForInstanceOfInvalidType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property name required to retrieve validation information for integration is not found..
        /// </summary>
        public static string ExceptionIntegrationValidatedPropertyNameNotAvailable {
            get {
                return ResourceManager.GetString("ExceptionIntegrationValidatedPropertyNameNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property name required to retrieve validation information for integration is invalid or does not belong to a public property..
        /// </summary>
        public static string ExceptionIntegrationValidatedPropertyNotExists {
            get {
                return ResourceManager.GetString("ExceptionIntegrationValidatedPropertyNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property name required to retrieve validation information for integration refers to nonreadable property..
        /// </summary>
        public static string ExceptionIntegrationValidatedPropertyNotReadable {
            get {
                return ResourceManager.GetString("ExceptionIntegrationValidatedPropertyNotReadable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type required to retrieve validation information for integration is not found..
        /// </summary>
        public static string ExceptionIntegrationValidatedTypeNotAvailable {
            get {
                return ResourceManager.GetString("ExceptionIntegrationValidatedTypeNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The target element type has not been set in the configuration..
        /// </summary>
        public static string ExceptionObjectCollectionValidatorDataTargetTypeNotSet {
            get {
                return ResourceManager.GetString("ExceptionObjectCollectionValidatorDataTargetTypeNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A validation attribute of type {0} cannot be used to validate values..
        /// </summary>
        public static string ExceptionValidationAttributeNotSupported {
            get {
                return ResourceManager.GetString("ExceptionValidationAttributeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value is not null and failed all its validation rules for key &quot;{1}&quot;..
        /// </summary>
        public static string IgnoreNullsDefaultMessageTemplate {
            get {
                return ResourceManager.GetString("IgnoreNullsDefaultMessageTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The InjectionValidationSource may only be used to configure generic Enterprise Library validator classes..
        /// </summary>
        public static string IllegalUseOfInjectionValidationSource {
            get {
                return ResourceManager.GetString("IllegalUseOfInjectionValidationSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ValidationDependencyAttribute was applied to a dependency of type {0}, which is a generic Enterprise Library validator class..
        /// </summary>
        public static string IllegalUseOfValidationDependencyAttribute {
            get {
                return ResourceManager.GetString("IllegalUseOfValidationDependencyAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Validation Specification Source {0} is invalid..
        /// </summary>
        public static string InvalidValidationSpecificationSource {
            get {
                return ResourceManager.GetString("InvalidValidationSpecificationSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InvariantCulture cannot be used to deserialize configuration..
        /// </summary>
        public static string InvariantCultureCannotBeUsedToDeserializeConfiguration {
            get {
                return ResourceManager.GetString("InvariantCultureCannotBeUsedToDeserializeConfiguration", resourceCulture);
            }
        }
    }
}
