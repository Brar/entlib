﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Caching Application Block
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

namespace Microsoft.Practices.EnterpriseLibrary.Caching.Tests.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Caching.Tests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Enterprise Library Caching.
        /// </summary>
        internal static string CachingInstrumentationCounterCategory {
            get {
                return ResourceManager.GetString("CachingInstrumentationCounterCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total # of Cache Access Attempts.
        /// </summary>
        internal static string PerfCounterCacheAccessAttempts {
            get {
                return ResourceManager.GetString("PerfCounterCacheAccessAttempts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cache Hit Ratio.
        /// </summary>
        internal static string PerfCounterCacheHitRatio {
            get {
                return ResourceManager.GetString("PerfCounterCacheHitRatio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cache Hits Per Sec.
        /// </summary>
        internal static string PerfCounterCacheHitsSec {
            get {
                return ResourceManager.GetString("PerfCounterCacheHitsSec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cache Misses Per Sec.
        /// </summary>
        internal static string PerfCounterCacheMissesSec {
            get {
                return ResourceManager.GetString("PerfCounterCacheMissesSec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cache Total Turnover Rate.
        /// </summary>
        internal static string PerfCounterCacheTurnoverRate {
            get {
                return ResourceManager.GetString("PerfCounterCacheTurnoverRate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total Cache Entries.
        /// </summary>
        internal static string PerfCounterTotalCacheEntries {
            get {
                return ResourceManager.GetString("PerfCounterTotalCacheEntries", resourceCulture);
            }
        }
    }
}
