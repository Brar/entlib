﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWC = System.Windows.Controls;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Integration.WPF.Tests
{
    [TestClass]
    public class IntegrationFixture
    {
        [TestMethod]
        public void CanValidateWithExplicitlySuppliedValidatorRule()
        {
            var control = new ControlWithExplicitRule();

            var textBox = control.TextBox1;

            textBox.Text = "bbbbbbbbbbb";

            Assert.IsTrue(SWC.Validation.GetHasError(textBox));
            Assert.AreEqual("invalid string", SWC.Validation.GetErrors(textBox).First().ErrorContent);
        }

        [TestMethod]
        public void CanValidateWithValidatorRuleSpecifiedWithAttachedProperties()
        {
            var control = new ControlWithExplicitRule();

            var textBox = control.TextBox1;

            textBox.Text = "bbbbbbbbbbb";

            Assert.IsTrue(SWC.Validation.GetHasError(textBox));
            Assert.AreEqual("invalid string", SWC.Validation.GetErrors(textBox).First().ErrorContent);
        }

        [TestMethod]
        public void CanValidateWithValidatorRuleSpecifiedWithAttachedPropertiesUsingRuleset()
        {
            var control = new ControlWithImplicitRuleWithRulesetAndSource();

            var textBox = control.TextBoxWithRuleset;

            textBox.Text = "bbbbbbbbbbb";

            Assert.IsTrue(SWC.Validation.GetHasError(textBox));
            Assert.AreEqual("invalid string ruleset", SWC.Validation.GetErrors(textBox).First().ErrorContent);
        }

        [TestMethod]
        public void CanValidateWithValidatorRuleSpecifiedWithAttachedPropertiesUsingSpecificationSource()
        {
            var control = new ControlWithImplicitRuleWithRulesetAndSource();

            var textBox = control.TextBoxWithSource;

            textBox.Text = "bbbbbbbbbbb";

            Assert.IsTrue(SWC.Validation.GetHasError(textBox));
            Assert.AreEqual("invalid string: vab", SWC.Validation.GetErrors(textBox).First().ErrorContent);
        }
    }
}
