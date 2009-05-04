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

using System;
using System.Configuration;
using System.Reflection;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Validation.Instrumentation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Microsoft.Practices.EnterpriseLibrary.Validation
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigurationValidatorBuilder : ValidatorBuilderBase
    {
        private IConfigurationSource configurationSource;
        private ValidationInstrumentationListener instrumentationListener;

        private static readonly Validator emptyValidator = new AndCompositeValidator();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configurationSource"></param>
        public ConfigurationValidatorBuilder(IConfigurationSource configurationSource)
            : base()
        {
            this.configurationSource = configurationSource;
            InitializeInstrumentationListener();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configurationSource"></param>
        /// <param name="memberAccessValidatorFactory"></param>
        public ConfigurationValidatorBuilder(IConfigurationSource configurationSource,
            MemberAccessValidatorBuilderFactory memberAccessValidatorFactory)
            : base(memberAccessValidatorFactory)
        {
            this.configurationSource = configurationSource;
            InitializeInstrumentationListener();
        }

        private void InitializeInstrumentationListener()
        {
            ValidationInstrumentationListenerCustomFactory instrumentationListenerFactory = new ValidationInstrumentationListenerCustomFactory();
            instrumentationListener = (ValidationInstrumentationListener)instrumentationListenerFactory.CreateObject(null, null, configurationSource, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ruleset"></param>
        /// <returns></returns>
        public Validator CreateValidator(Type type, string ruleset)
        {

            ValidatedTypeReference typeReference = GetTypeReference(type);
            if (null == typeReference)
                return emptyValidator;

            return CreateValidator(type, typeReference, ruleset);
        }

        private ValidatedTypeReference GetTypeReference(Type type)
        {
            try
            {
                ValidationSettings validationSettings
                    = this.configurationSource.GetSection(ValidationSettings.SectionName) as ValidationSettings;
                if (null == validationSettings)
                    return null;

                ValidatedTypeReference typeReference = validationSettings.Types.Get(type.FullName);
                return typeReference;
            }
            catch (ConfigurationErrorsException configurationErrors)
            {
                instrumentationListener.ConfigurationFailure(this, new ValidationConfigurationFailureEventArgs(configurationErrors));
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="typeReference"></param>
        /// <param name="ruleset"></param>
        /// <returns></returns>
        public Validator CreateValidator(Type type, ValidatedTypeReference typeReference, string ruleset)
        {
            if (string.IsNullOrEmpty(ruleset))
            {
                ruleset = typeReference.DefaultRuleset;
            }

            ValidationRulesetData ruleData = typeReference.Rulesets.Get(ruleset);

            if (null == ruleData)
                return emptyValidator;

            return this.CreateValidator(new ConfigurationValidatedType(ruleData, type));
        }

        internal IConfigurationSource ConfigurationSource
        {
            get { return this.configurationSource; }
        }

        #region test only methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ruleData"></param>
        /// <returns></returns>
        public Validator CreateValidatorForRule(Type type, ValidationRulesetData ruleData)
        {
            return CreateValidator(new ConfigurationValidatedType(ruleData, type));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="ruleData"></param>
        /// <returns></returns>
        public Validator CreateValidatorForType(Type type, ValidationRulesetData ruleData)
        {
            if (ruleData.Validators.Count == 0)
                return null;

            ConfigurationValidatedType validatedElement = new ConfigurationValidatedType(ruleData, type);

            return CreateValidatorForValidatedElement(validatedElement, this.GetCompositeValidatorBuilderForType);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="propertyReference"></param>
        /// <returns></returns>
        public Validator CreateValidatorForProperty(Type type, ValidatedPropertyReference propertyReference)
        {
            if (propertyReference.Validators.Count == 0)
                return null;

            PropertyInfo propertyInfo = ValidationReflectionHelper.GetProperty(type, propertyReference.Name, false);
            if (propertyInfo == null)
                return null;

            ConfigurationValidatedElement validatedElement = new ConfigurationValidatedElement(propertyReference, propertyInfo);

            return CreateValidatorForValidatedElement(validatedElement, this.GetCompositeValidatorBuilderForProperty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="fieldReference"></param>
        /// <returns></returns>
        public Validator CreateValidatorForField(Type type, ValidatedFieldReference fieldReference)
        {
            if (fieldReference.Validators.Count == 0)
                return null;

            FieldInfo fieldInfo = ValidationReflectionHelper.GetField(type, fieldReference.Name, false);
            if (fieldInfo == null)
                return null;

            ConfigurationValidatedElement validatedElement = new ConfigurationValidatedElement(fieldReference, fieldInfo);

            return CreateValidatorForValidatedElement(validatedElement, this.GetCompositeValidatorBuilderForField);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="methodReference"></param>
        /// <returns></returns>
        public Validator CreateValidatorForMethod(Type type, ValidatedMethodReference methodReference)
        {
            if (methodReference.Validators.Count == 0)
                return null;

            MethodInfo methodInfo = ValidationReflectionHelper.GetMethod(type, methodReference.Name, false);
            if (methodInfo == null)
                return null;

            ConfigurationValidatedElement validatedElement = new ConfigurationValidatedElement(methodReference, methodInfo);

            return CreateValidatorForValidatedElement(validatedElement, this.GetCompositeValidatorBuilderForMethod);
        }

        #endregion
    }
}
