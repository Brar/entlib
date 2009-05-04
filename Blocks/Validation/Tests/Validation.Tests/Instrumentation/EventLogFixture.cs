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
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.TestSupport;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.Tests.Instrumentation
{
    [TestClass]
    public class EventLogFixture
    {
        [TestInitialize]
        public void TestInitialize()
        {
            AppDomain.CurrentDomain.SetData("APPBASE", Environment.CurrentDirectory);
        }

        [TestMethod, DeploymentItem("errornous.config")]
        public void ConfigurationErrorsAreLoggedInEventLog()
        {
            FileConfigurationSource configurationSourceWithInvalidConfiguration = new FileConfigurationSource("errornous.config");

            using (EventLog eventLog = GetEventLog())
            {
                int originalEventCount = eventLog.Entries.Count;

                try
                {
                    ValidationFactory.CreateValidator<EventLogFixture>(configurationSourceWithInvalidConfiguration);
                    Assert.Fail();
                }
                catch (ConfigurationErrorsException e)
                {
                    Assert.IsTrue(eventLog.Entries.Count > originalEventCount);
                    var newValidationEntries =
                        (from entry in eventLog.GetNewEntries(originalEventCount)
                         where entry.Source == "Enterprise Library Validation" &&
                               entry.Message.IndexOf(e.Message) > -1
                         select entry).ToList();

                    Assert.AreEqual(1, newValidationEntries.Count);
                }
            }
        }

        static EventLog GetEventLog()
        {
            return new EventLog("Application", ".", "Enterprise Library Validation");
        }
    }
}
