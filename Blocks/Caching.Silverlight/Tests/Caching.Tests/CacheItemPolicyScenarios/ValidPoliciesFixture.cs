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

using System;
using Microsoft.Practices.EnterpriseLibrary.Caching.InMemory;
using Microsoft.Practices.EnterpriseLibrary.Caching.Runtime.Caching;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Caching.Tests.CacheItemPolicyScenarios
{
    [TestClass]
    public class ValidPoliciesFixture
    {
        [TestMethod]
        public void CanSpecifyAbsoluteExpiration()
        {
            var policy = new CacheItemPolicy { AbsoluteExpiration = DateTime.Now.AddDays(1) };
            policy.Validate();
        }

        [TestMethod]
        public void CanSpecifySlidingExpiration()
        {
            var policy = new CacheItemPolicy { SlidingExpiration = TimeSpan.FromHours(1) };
            policy.Validate();
        }

        [TestMethod]
        public void CanSpecifyRemovedCallback()
        {
            var policy = new CacheItemPolicy { RemovedCallback = a => { } };
            policy.Validate();
        }

        [TestMethod]
        public void CanSpecifyUpdateCallback()
        {
            var policy = new CacheItemPolicy { UpdateCallback = a => { } };
            policy.Validate();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CannotSpecifyBothAbsoluteAndSlidingExpiration()
        {
            var policy = new CacheItemPolicy 
            {
                AbsoluteExpiration = DateTime.Now.AddDays(1), 
                SlidingExpiration = TimeSpan.FromHours(1) 
            };

            policy.Validate();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CannotSpecifyNegativeSlidingExpiration()
        {
            var policy = new CacheItemPolicy { SlidingExpiration = TimeSpan.FromHours(-1) };

            policy.Validate();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CannotSpecifyBothRemovedAndUpdateCallbacks()
        {
            var policy = new CacheItemPolicy
            {
                RemovedCallback = a => { },
                UpdateCallback = a => { },
            };

            policy.Validate();
        }
    }
}
