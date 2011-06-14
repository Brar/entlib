﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Data Access Application Block
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

namespace Microsoft.Practices.EnterpriseLibrary.Data.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Data.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The database type &quot;{0}&quot; does not support asynchronous operations..
        /// </summary>
        internal static string AsyncOperationsNotSupported {
            get {
                return ResourceManager.GetString("AsyncOperationsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enterprise Library Data Access Application Block.
        /// </summary>
        internal static string BlockName {
            get {
                return ResourceManager.GetString("BlockName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commands Executed/sec is the rate at which database commands were executed..
        /// </summary>
        internal static string CommandExecutedCounterHelpResource {
            get {
                return ResourceManager.GetString("CommandExecutedCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commands Failed/sec is tha rate at which database commands failed to execute..
        /// </summary>
        internal static string CommandFailedCounterHelpResource {
            get {
                return ResourceManager.GetString("CommandFailedCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A configuration failure occurred while creating database ‘{0}’..
        /// </summary>
        internal static string ConfigurationFailureCreatingDatabase {
            get {
                return ResourceManager.GetString("ConfigurationFailureCreatingDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connections Failed/sec is the rate at which database connections failed to open..
        /// </summary>
        internal static string ConnectionFailedCounterHelpResource {
            get {
                return ResourceManager.GetString("ConnectionFailedCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connections Opened/sec is the rate at which database connections were opened..
        /// </summary>
        internal static string ConnectionOpenedCounterHelpResource {
            get {
                return ResourceManager.GetString("ConnectionOpenedCounterHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enterprise Library Data Performance Counter Instances.
        /// </summary>
        internal static string CounterCategoryHelpResourceName {
            get {
                return ResourceManager.GetString("CounterCategoryHelpResourceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database=Database;Server=(local)\SQLEXPRESS;Integrated Security=SSPI.
        /// </summary>
        internal static string DefaultSqlConnctionString {
            get {
                return ResourceManager.GetString("DefaultSqlConnctionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection string used was &quot;{0}&quot;..
        /// </summary>
        internal static string ErrorConnectionFailedExtraInformation {
            get {
                return ResourceManager.GetString("ErrorConnectionFailedExtraInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The error occurred using the &quot;{0}&quot; database instance while attempting to open the database connection..
        /// </summary>
        internal static string ErrorConnectionFailedMessage {
            get {
                return ResourceManager.GetString("ErrorConnectionFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expression must contain a MemberAccessExpression to a property ( t =&gt;t.Property)..
        /// </summary>
        internal static string ExceptionArgumentMustBePropertyExpression {
            get {
                return ResourceManager.GetString("ExceptionArgumentMustBePropertyExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type must inherit from Microsoft.Practices.EnterpriseLibrary.Data.Database.
        /// </summary>
        internal static string ExceptionArgumentMustInheritFromDatabase {
            get {
                return ResourceManager.GetString("ExceptionArgumentMustInheritFromDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create a mapping for type {0}..
        /// </summary>
        internal static string ExceptionCannotCreateRowMapping {
            get {
                return ResourceManager.GetString("ExceptionCannotCreateRowMapping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The column {0} was not found on the IDataRecord being evaluated. This might indicate that the accessor was created with the wrong mappings..
        /// </summary>
        internal static string ExceptionColumnNotFoundWhileMapping {
            get {
                return ResourceManager.GetString("ExceptionColumnNotFoundWhileMapping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The command must be a SqlCommand..
        /// </summary>
        internal static string ExceptionCommandNotSqlCommand {
            get {
                return ResourceManager.GetString("ExceptionCommandNotSqlCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value from column &apos;{0}&apos; cannot be converted to property &apos;{1}&apos; of type &apos;{2}&apos;..
        /// </summary>
        internal static string ExceptionConvertionFailedWhenMappingPropertyToColumn {
            get {
                return ResourceManager.GetString("ExceptionConvertionFailedWhenMappingPropertyToColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration element type {0} does not have an accessible constructor taking a ConnectionStringSettings and an IConfigurationSource as constructor arguments..
        /// </summary>
        internal static string ExceptionDatabaseDataTypeDoesNotHaveRequiredConstructor {
            get {
                return ResourceManager.GetString("ExceptionDatabaseDataTypeDoesNotHaveRequiredConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration element type {0} does not inherit from the DatabaseData class..
        /// </summary>
        internal static string ExceptionDatabaseDataTypeDoesNotInheritFromDatabaseData {
            get {
                return ResourceManager.GetString("ExceptionDatabaseDataTypeDoesNotInheritFromDatabaseData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The database type {0} for the name {1} does not have the required [DatabaseAssembler] attribute required to build the database object..
        /// </summary>
        internal static string ExceptionDatabaseTypeDoesNotHaveAssemblerAttribute {
            get {
                return ResourceManager.GetString("ExceptionDatabaseTypeDoesNotHaveAssemblerAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The database type {0} does not have the required ConfigurationElementType attribute..
        /// </summary>
        internal static string ExceptionDatabaseTypeDoesNotHaveRequiredConfigurationTypeAttribute {
            get {
                return ResourceManager.GetString("ExceptionDatabaseTypeDoesNotHaveRequiredConfigurationTypeAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of parameters does not match number of values for stored procedure..
        /// </summary>
        internal static string ExceptionMessageParameterMatchFailure {
            get {
                return ResourceManager.GetString("ExceptionMessageParameterMatchFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one command must be initialized.
        /// </summary>
        internal static string ExceptionMessageUpdateDataSetArgumentFailure {
            get {
                return ResourceManager.GetString("ExceptionMessageUpdateDataSetArgumentFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to update row .
        /// </summary>
        internal static string ExceptionMessageUpdateDataSetRowFailure {
            get {
                return ResourceManager.GetString("ExceptionMessageUpdateDataSetRowFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} does not contain the ConfigurationElementTypeAttribute..
        /// </summary>
        internal static string ExceptionNoConfigurationElementTypeAttribute {
            get {
                return ResourceManager.GetString("ExceptionNoConfigurationElementTypeAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested database {0} is not defined in configuration..
        /// </summary>
        internal static string ExceptionNoDatabaseDefined {
            get {
                return ResourceManager.GetString("ExceptionNoDatabaseDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested database {0} does not have provider name set in the connection string..
        /// </summary>
        internal static string ExceptionNoProviderDefinedForConnectionString {
            get {
                return ResourceManager.GetString("ExceptionNoProviderDefinedForConnectionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can not be null or an empty string..
        /// </summary>
        internal static string ExceptionNullOrEmptyString {
            get {
                return ResourceManager.GetString("ExceptionNullOrEmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The database type &quot;{0}&quot; does not support automatic parameter discovery. Use an IParameterMapper instead..
        /// </summary>
        internal static string ExceptionParameterDiscoveryNotSupported {
            get {
                return ResourceManager.GetString("ExceptionParameterDiscoveryNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter discovery is not supported for connections using GenericDatabase. You must specify the parameters explicitly, or configure the connection to use a type deriving from Database that supports parameter discovery..
        /// </summary>
        internal static string ExceptionParameterDiscoveryNotSupportedOnGenericDatabase {
            get {
                return ResourceManager.GetString("ExceptionParameterDiscoveryNotSupportedOnGenericDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sql String Accessor cannot be used to discover parameters. Use an IParameterMapper instead..
        /// </summary>
        internal static string ExceptionSqlStringAccessorCannotDiscoverParameters {
            get {
                return ResourceManager.GetString("ExceptionSqlStringAccessorCannotDiscoverParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The table name array used to map results to user-specified table names cannot be empty..
        /// </summary>
        internal static string ExceptionTableNameArrayEmpty {
            get {
                return ResourceManager.GetString("ExceptionTableNameArrayEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type {0} is not an implementation of IDatabaseAssembler for DatabaseAssemblerAttribute..
        /// </summary>
        internal static string ExceptionTypeNotDatabaseAssembler {
            get {
                return ResourceManager.GetString("ExceptionTypeNotDatabaseAssembler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to password=,pwd=.
        /// </summary>
        internal static string Password {
            get {
                return ResourceManager.GetString("Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total Commands Executed is the total number which database commands were executed..
        /// </summary>
        internal static string TotalCommandsExecutedHelpResource {
            get {
                return ResourceManager.GetString("TotalCommandsExecutedHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total Commands Failed is the total number which database commands failed to execute..
        /// </summary>
        internal static string TotalCommandsFailedHelpResource {
            get {
                return ResourceManager.GetString("TotalCommandsFailedHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total Connections Failed is the total number which database connections failed to open..
        /// </summary>
        internal static string TotalConnectionFailedHelpResource {
            get {
                return ResourceManager.GetString("TotalConnectionFailedHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total Connections Opened is the total number which database connections were opened..
        /// </summary>
        internal static string TotalConnectionOpenedHelpResource {
            get {
                return ResourceManager.GetString("TotalConnectionOpenedHelpResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to user id=,uid=.
        /// </summary>
        internal static string UserName {
            get {
                return ResourceManager.GetString("UserName", resourceCulture);
            }
        }
    }
}
