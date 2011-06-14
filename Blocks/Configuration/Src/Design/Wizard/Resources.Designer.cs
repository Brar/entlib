﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
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
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Wizard {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Wizard.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Exception Type.
        /// </summary>
        internal static string PickExceptionTypeStepExceptionTypeDisplayName {
            get {
                return ResourceManager.GetString("PickExceptionTypeStepExceptionTypeDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Policy.
        /// </summary>
        internal static string PickExceptionTypeStepPolicyDisplayName {
            get {
                return ResourceManager.GetString("PickExceptionTypeStepPolicyDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection Name.
        /// </summary>
        internal static string SelectDatabaseStepConnectionNameDisplayName {
            get {
                return ResourceManager.GetString("SelectDatabaseStepConnectionNameDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider Name.
        /// </summary>
        internal static string SelectDatabaseStepConnectionProviderNameDisplayName {
            get {
                return ResourceManager.GetString("SelectDatabaseStepConnectionProviderNameDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection String.
        /// </summary>
        internal static string SelectDatabaseStepConnectionStringDisplayName {
            get {
                return ResourceManager.GetString("SelectDatabaseStepConnectionStringDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An Error Occurred In The Wizard.
        /// </summary>
        internal static string WizardErrorDuringExecutionTitle {
            get {
                return ResourceManager.GetString("WizardErrorDuringExecutionTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log Exception To Database.
        /// </summary>
        internal static string WizardLogExceptionsToDatabaseTitle {
            get {
                return ResourceManager.GetString("WizardLogExceptionsToDatabaseTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select an exception type.  Then, select enter or select an exception handling policy for the selected type..
        /// </summary>
        internal static string WizardPickExceptionTypeInstructions {
            get {
                return ResourceManager.GetString("WizardPickExceptionTypeInstructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pick exception type..
        /// </summary>
        internal static string WizardPickExceptionTypeStepTitle {
            get {
                return ResourceManager.GetString("WizardPickExceptionTypeStepTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred retrieving the wizard&apos;s Title..
        /// </summary>
        internal static string WizardRetrievingTitleError {
            get {
                return ResourceManager.GetString("WizardRetrievingTitleError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter new database connection information or select an existing database connection, if one is available..
        /// </summary>
        internal static string WizardSelectDatabaseStepInstructions {
            get {
                return ResourceManager.GetString("WizardSelectDatabaseStepInstructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a database..
        /// </summary>
        internal static string WizardSelectDatabaseStepTitle {
            get {
                return ResourceManager.GetString("WizardSelectDatabaseStepTitle", resourceCulture);
            }
        }
    }
}
