﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Logging Application Block
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

namespace Microsoft.Practices.EnterpriseLibrary.Logging.MsmqDistributor.Tests.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Logging.MsmqDistributor.Tests.Properties.Re" +
                            "sources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The Windows service initialization sequence is complete. No errors have occurred..
        /// </summary>
        internal static string InitializeComponentCompleted {
            get {
                return ResourceManager.GetString("InitializeComponentCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Windows service initialization sequence has started..
        /// </summary>
        internal static string InitializeComponentStarted {
            get {
                return ResourceManager.GetString("InitializeComponentStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access denied to the DistributorMSMQ queue &apos;{0}&apos;. Identity trying to access the queue : {1}.   See &apos;Exception Information Details&apos; below for more information..
        /// </summary>
        internal static string MsmqAccessDenied {
            get {
                return ResourceManager.GetString("MsmqAccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; was paused correctly..
        /// </summary>
        internal static string ServicePausedSuccess {
            get {
                return ResourceManager.GetString("ServicePausedSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; did not pause correctly.
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information. The service will be stopped..
        /// </summary>
        internal static string ServicePauseError {
            get {
                return ResourceManager.GetString("ServicePauseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; did not pause gracefully. 
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information..
        /// </summary>
        internal static string ServicePauseWarning {
            get {
                return ResourceManager.GetString("ServicePauseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  The service &apos;{0}&apos; resumed correctly..
        /// </summary>
        internal static string ServiceResumeComplete {
            get {
                return ResourceManager.GetString("ServiceResumeComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  The service &apos;{0}&apos; was not resumed correctly.
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information. The service will be stopped..
        /// </summary>
        internal static string ServiceResumeError {
            get {
                return ResourceManager.GetString("ServiceResumeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; started correctly..
        /// </summary>
        internal static string ServiceStartComplete {
            get {
                return ResourceManager.GetString("ServiceStartComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while starting the service {0}.
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information. The service needs to be stopped..
        /// </summary>
        internal static string ServiceStartError {
            get {
                return ResourceManager.GetString("ServiceStartError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; stopped correctly..
        /// </summary>
        internal static string ServiceStopComplete {
            get {
                return ResourceManager.GetString("ServiceStopComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; did not stop correctly.
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information. The service will be stopped..
        /// </summary>
        internal static string ServiceStopError {
            get {
                return ResourceManager.GetString("ServiceStopError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; did not stop gracefully. 
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information..
        /// </summary>
        internal static string ServiceStopWarning {
            get {
                return ResourceManager.GetString("ServiceStopWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The validation sequence is complete. No errors have occurred..
        /// </summary>
        internal static string ValidationComplete {
            get {
                return ResourceManager.GetString("ValidationComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred in one of the validation sequences. See &apos;Exception Information Details&apos; below for more information. The service will be stopped..
        /// </summary>
        internal static string ValidationError {
            get {
                return ResourceManager.GetString("ValidationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The validation sequence has been started..
        /// </summary>
        internal static string ValidationStarted {
            get {
                return ResourceManager.GetString("ValidationStarted", resourceCulture);
            }
        }
    }
}
