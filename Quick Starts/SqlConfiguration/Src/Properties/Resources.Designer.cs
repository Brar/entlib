﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// SQL Configuration Source QuickStart
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
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.SqlConfigurationSource.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.SqlConfigurationSource.Properties.Resources" +
                            "", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Configuration information already set..
        /// </summary>
        internal static string ExceptionConfigurationAlreadySet {
            get {
                return ResourceManager.GetString("ExceptionConfigurationAlreadySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set Sql Configuration information.
        /// </summary>
        internal static string ExceptionConfigurationCannotSet {
            get {
                return ResourceManager.GetString("ExceptionConfigurationCannotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SqlConfigurationManager could not be initialized.
        /// </summary>
        internal static string ExceptionConfigurationInitialization {
            get {
                return ResourceManager.GetString("ExceptionConfigurationInitialization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ConfigurationSection must be of type SerializableConfigurationSection to be used with the SqlConfigurationSource.
        /// </summary>
        internal static string ExceptionConfigurationSectionNotSerializable {
            get {
                return ResourceManager.GetString("ExceptionConfigurationSectionNotSerializable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can not retrieve configuration information for the section &apos;{0}&apos;.
        /// </summary>
        internal static string ExceptionConfigurationSqlInvalidSection {
            get {
                return ResourceManager.GetString("ExceptionConfigurationSqlInvalidSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can not be null or string or empty..
        /// </summary>
        internal static string ExceptionStringNullOrEmpty {
            get {
                return ResourceManager.GetString("ExceptionStringNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expected type &apos;{0}&apos; was not provided..
        /// </summary>
        internal static string ExceptionUnexpectedType {
            get {
                return ResourceManager.GetString("ExceptionUnexpectedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sql Configuration Source.
        /// </summary>
        internal static string SqlConfigurationSourceName {
            get {
                return ResourceManager.GetString("SqlConfigurationSourceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enterprise Library Configuration.
        /// </summary>
        internal static string SqlWatcherEventSource {
            get {
                return ResourceManager.GetString("SqlWatcherEventSource", resourceCulture);
            }
        }
    }
}
