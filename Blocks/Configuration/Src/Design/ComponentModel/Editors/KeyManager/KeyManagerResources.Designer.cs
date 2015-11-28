﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Security.Cryptography.Configuration.Design {
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
    internal class KeyManagerResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal KeyManagerResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ComponentModel.Editors" +
                            ".KeyManager.KeyManagerResources", typeof(KeyManagerResources).Assembly);
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
        ///   Looks up a localized string similar to The key for this algorithm is stored in a file. To further protect the key, it is encrypted using the Data Protection API (DPAPI).
        ///
        ///Please select the data protection mode. “User” mode will encrypt your data using the credentials of the currently logged-in user. “Machine” mode will allow any user on this computer to encrypt or decrypt the key..
        /// </summary>
        internal static string ChooseDpapiScopeMessage {
            get {
                return ResourceManager.GetString("ChooseDpapiScopeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please choose the location of the existing DPAPI-encrypted algorithm key file:.
        /// </summary>
        internal static string ChooseExistingKeyFileMessage {
            get {
                return ResourceManager.GetString("ChooseExistingKeyFileMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key for this algorithm will be encrypted and stored in a file. Please choose where you would like to store this file:.
        /// </summary>
        internal static string ChooseKeyFileMessage {
            get {
                return ResourceManager.GetString("ChooseKeyFileMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter or generate the key you would like to use for this algorithm (in hexadecimal):.
        /// </summary>
        internal static string CreateKeyMessage {
            get {
                return ResourceManager.GetString("CreateKeyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a new key.
        /// </summary>
        internal static string CreateNewKeyLabel {
            get {
                return ResourceManager.GetString("CreateNewKeyLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        internal static string CryptographicKeyWizardCancelButton {
            get {
                return ResourceManager.GetString("CryptographicKeyWizardCancelButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finish.
        /// </summary>
        internal static string CryptographicKeyWizardFinishButton {
            get {
                return ResourceManager.GetString("CryptographicKeyWizardFinishButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Next  &gt;.
        /// </summary>
        internal static string CryptographicKeyWizardNextButton {
            get {
                return ResourceManager.GetString("CryptographicKeyWizardNextButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;  Previous.
        /// </summary>
        internal static string CryptographicKeyWizardPreviousButton {
            get {
                return ResourceManager.GetString("CryptographicKeyWizardPreviousButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cryptographic Key Wizard.
        /// </summary>
        internal static string CryptographicKeyWizardTitle {
            get {
                return ResourceManager.GetString("CryptographicKeyWizardTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string CryptoKeyWizardErrorTitle {
            get {
                return ResourceManager.GetString("CryptoKeyWizardErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User mode.
        /// </summary>
        internal static string DataProtectionScopeCurrentUser {
            get {
                return ResourceManager.GetString("DataProtectionScopeCurrentUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Machine mode.
        /// </summary>
        internal static string DataProtectionScopeLocalMachine {
            get {
                return ResourceManager.GetString("DataProtectionScopeLocalMachine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password is not correct..
        /// </summary>
        internal static string DecryptPasswordCheckFailure {
            get {
                return ResourceManager.GetString("DecryptPasswordCheckFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred exporting the key..
        /// </summary>
        internal static string ErrorExportingKey {
            get {
                return ResourceManager.GetString("ErrorExportingKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred importing the key. Please make sure the file path and ProtectionScope are current..
        /// </summary>
        internal static string ErrorImportingKey {
            get {
                return ResourceManager.GetString("ErrorImportingKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use an existing DPAPI-protected key file.
        /// </summary>
        internal static string ExistingKeyLabel {
            get {
                return ResourceManager.GetString("ExistingKeyLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string ExportDialogErrorTitle {
            get {
                return ResourceManager.GetString("ExportDialogErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export Key As.
        /// </summary>
        internal static string ExportDialogTitle {
            get {
                return ResourceManager.GetString("ExportDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory is invalid..
        /// </summary>
        internal static string ExportDirectoryInvalid {
            get {
                return ResourceManager.GetString("ExportDirectoryInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export key.
        /// </summary>
        internal static string ExportKeyCommandText {
            get {
                return ResourceManager.GetString("ExportKeyCommandText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export Key Wizard.
        /// </summary>
        internal static string ExportKeyDialogTitle {
            get {
                return ResourceManager.GetString("ExportKeyDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key for this algorithm will be encrypted with a password and stored in a file. Please choose where you would like to store this file:.
        /// </summary>
        internal static string ExportKeyFileMessage {
            get {
                return ResourceManager.GetString("ExportKeyFileMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export cryptography key to archive..
        /// </summary>
        internal static string ExportKeyLongCommandText {
            get {
                return ResourceManager.GetString("ExportKeyLongCommandText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm password:.
        /// </summary>
        internal static string ExportKeyPasswordConfirmLabel {
            get {
                return ResourceManager.GetString("ExportKeyPasswordConfirmLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the password with which to encrypt this key file:.
        /// </summary>
        internal static string ExportKeyPasswordLabel {
            get {
                return ResourceManager.GetString("ExportKeyPasswordLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        internal static string ExportKeyUICancelButton {
            get {
                return ResourceManager.GetString("ExportKeyUICancelButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ok.
        /// </summary>
        internal static string ExportKeyUIOkButton {
            get {
                return ResourceManager.GetString("ExportKeyUIOkButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password must be at least {0} characters..
        /// </summary>
        internal static string ExportPasswordMinLength {
            get {
                return ResourceManager.GetString("ExportPasswordMinLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Passwords do not match..
        /// </summary>
        internal static string ExportPasswordsDoNotMatch {
            get {
                return ResourceManager.GetString("ExportPasswordsDoNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key has been exported successfully..
        /// </summary>
        internal static string ExportSuccessful {
            get {
                return ResourceManager.GetString("ExportSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export.
        /// </summary>
        internal static string ExportSuccessfulTitle {
            get {
                return ResourceManager.GetString("ExportSuccessfulTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the specified file..
        /// </summary>
        internal static string FileDoesNotExists {
            get {
                return ResourceManager.GetString("FileDoesNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file name should not be empty.
        /// </summary>
        internal static string FileShouldNotBeEmpty {
            get {
                return ResourceManager.GetString("FileShouldNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Generate.
        /// </summary>
        internal static string GenerateKeyButtonText {
            get {
                return ResourceManager.GetString("GenerateKeyButtonText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a new {0}.
        /// </summary>
        internal static string GenericCreateStatusText {
            get {
                return ResourceManager.GetString("GenericCreateStatusText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please choose the location of the existing password-encrypted algorithm key file:.
        /// </summary>
        internal static string ImportArchivedKeyMessage {
            get {
                return ResourceManager.GetString("ImportArchivedKeyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter the password that was used to encrypt this key file:.
        /// </summary>
        internal static string ImportArchivedKeyPasswordLabel {
            get {
                return ResourceManager.GetString("ImportArchivedKeyPasswordLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to decrypt key.  Password may be incorrect..
        /// </summary>
        internal static string ImportDecryptError {
            get {
                return ResourceManager.GetString("ImportDecryptError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read key file. File format may be invalid..
        /// </summary>
        internal static string ImportDecryptFormatError {
            get {
                return ResourceManager.GetString("ImportDecryptFormatError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string ImportDialogErrorTitle {
            get {
                return ResourceManager.GetString("ImportDialogErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open key archive.
        /// </summary>
        internal static string ImportDialogTitle {
            get {
                return ResourceManager.GetString("ImportDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import a password-protected key file.
        /// </summary>
        internal static string ImportKeyLabel {
            get {
                return ResourceManager.GetString("ImportKeyLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password is invalid..
        /// </summary>
        internal static string ImportPasswordInvalid {
            get {
                return ResourceManager.GetString("ImportPasswordInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string ImportPasswordInvalidTitle {
            get {
                return ResourceManager.GetString("ImportPasswordInvalidTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File does not exist..
        /// </summary>
        internal static string ImportSourceFileInvalid {
            get {
                return ResourceManager.GetString("ImportSourceFileInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key has been imported successfully..
        /// </summary>
        internal static string ImportSuccessful {
            get {
                return ResourceManager.GetString("ImportSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import.
        /// </summary>
        internal static string ImportSuccessfulTitle {
            get {
                return ResourceManager.GetString("ImportSuccessfulTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid export destination..
        /// </summary>
        internal static string InvalidExportDestination {
            get {
                return ResourceManager.GetString("InvalidExportDestination", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid source file..
        /// </summary>
        internal static string InvalidImportSource {
            get {
                return ResourceManager.GetString("InvalidImportSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key is not set and node is invalid. Please delete this node and recreate it with a valid key..
        /// </summary>
        internal static string InvalidKeyWhenSavingError {
            get {
                return ResourceManager.GetString("InvalidKeyWhenSavingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key export files (*.txt)|*.txt|All files (*.*)|*.*.
        /// </summary>
        internal static string KeyArchiveFileFilter {
            get {
                return ResourceManager.GetString("KeyArchiveFileFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not read key from archive. Password might be incorrect..
        /// </summary>
        internal static string KeyCouldNotBeRead {
            get {
                return ResourceManager.GetString("KeyCouldNotBeRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keyed Hash Provider.
        /// </summary>
        internal static string KeyedHashProviderNodeName {
            get {
                return ResourceManager.GetString("KeyedHashProviderNodeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid key file name. Please re-enter..
        /// </summary>
        internal static string KeyFileBadNameError {
            get {
                return ResourceManager.GetString("KeyFileBadNameError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key files (*.key)|*.key|All files (*.*)|*.*.
        /// </summary>
        internal static string KeyFileFilter {
            get {
                return ResourceManager.GetString("KeyFileFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load cryptographic configuration -- Cannot open key file {0}. Configuration will be removed..
        /// </summary>
        internal static string KeyFileLoadingError {
            get {
                return ResourceManager.GetString("KeyFileLoadingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid property type.  You may only use the KeyManagerEditor on properties of the type KeyInfo..
        /// </summary>
        internal static string KeyManagerEditorRequiresKeyInfoProperty {
            get {
                return ResourceManager.GetString("KeyManagerEditorRequiresKeyInfoProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key Size:.
        /// </summary>
        internal static string KeyManagerUICurrentKeySizeCaption {
            get {
                return ResourceManager.GetString("KeyManagerUICurrentKeySizeCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key.
        /// </summary>
        internal static string KeyManagerUIInvalidKey {
            get {
                return ResourceManager.GetString("KeyManagerUIInvalidKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key must be in hexadecimal form (for example, 49FFC7).
        /// </summary>
        internal static string KeyManagerUIInvalidKeyCharactersErrorMessage {
            get {
                return ResourceManager.GetString("KeyManagerUIInvalidKeyCharactersErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid key length.
        /// </summary>
        internal static string KeyManagerUIInvalidKeyLengthErrorMessage {
            get {
                return ResourceManager.GetString("KeyManagerUIInvalidKeyLengthErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key is hidden for security purposes.  If you would like a new key you must create a new cryptography instance.  If you must replace the key for this instance, delete this instance and create a new instance with the same name..
        /// </summary>
        internal static string KeyManagerUIKeyBoxEncrypted {
            get {
                return ResourceManager.GetString("KeyManagerUIKeyBoxEncrypted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a key..
        /// </summary>
        internal static string KeyShouldNotBeEmpty {
            get {
                return ResourceManager.GetString("KeyShouldNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load key from file {0}.
        ///
        ///Exception message is: &apos;{1}&apos;.
        ///
        ///Would you like to proceed and generate a new key?.
        /// </summary>
        internal static string LoadExistingKeyFileFailureErrorMessage {
            get {
                return ResourceManager.GetString("LoadExistingKeyFileFailureErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key file is password protected and no password was provided..
        /// </summary>
        internal static string MissingPassword {
            get {
                return ResourceManager.GetString("MissingPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to open Key key file: {0}.
        ///
        ///Exception message is: &apos;{1}&apos;..
        /// </summary>
        internal static string OpenExistingKeyFileFailureErrorMessage {
            get {
                return ResourceManager.GetString("OpenExistingKeyFileFailureErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to open key file.
        /// </summary>
        internal static string OpenExistingKeyFileFailureTitle {
            get {
                return ResourceManager.GetString("OpenExistingKeyFileFailureTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open existing key file.
        /// </summary>
        internal static string OpenExistingKeyFileTitle {
            get {
                return ResourceManager.GetString("OpenExistingKeyFileTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Export Key.
        /// </summary>
        internal static string OverwriteExportFileCaption {
            get {
                return ResourceManager.GetString("OverwriteExportFileCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} is read-only.  Would you like to overwrite the file?.
        /// </summary>
        internal static string OverwriteExportFileMessage {
            get {
                return ResourceManager.GetString("OverwriteExportFileMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;hidden&gt;.
        /// </summary>
        internal static string ProtectedKeySettingsToString {
            get {
                return ResourceManager.GetString("ProtectedKeySettingsToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DataProtectionScope that should be used..
        /// </summary>
        internal static string ProtectionScopeDescription {
            get {
                return ResourceManager.GetString("ProtectionScopeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose key file.
        /// </summary>
        internal static string SaveExistingKeyFileTitle {
            get {
                return ResourceManager.GetString("SaveExistingKeyFileTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to use this algorithm, you must supply a key. You can either create a new key, or use an existing key..
        /// </summary>
        internal static string SupplyKeyMessage {
            get {
                return ResourceManager.GetString("SupplyKeyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type should derive from System.Security.Cryptography.HashAlgorithm..
        /// </summary>
        internal static string TypeShouldDeriveFromHashAlgorithm {
            get {
                return ResourceManager.GetString("TypeShouldDeriveFromHashAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type should derive from System.Security.Cryptography.SymmetricAlgorithm..
        /// </summary>
        internal static string TypeShouldDeriveFromSymmetricAlgorithm {
            get {
                return ResourceManager.GetString("TypeShouldDeriveFromSymmetricAlgorithm", resourceCulture);
            }
        }
    }
}
