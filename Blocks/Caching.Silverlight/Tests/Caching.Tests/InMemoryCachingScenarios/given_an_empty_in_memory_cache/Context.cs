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
using Microsoft.Practices.EnterpriseLibrary.Caching.Scheduling;
using Microsoft.Practices.EnterpriseLibrary.Common.TestSupport.ContextBase;
using Microsoft.Practices.EnterpriseLibrary.Common.Utility;
using Moq;

namespace Microsoft.Practices.EnterpriseLibrary.Caching.Tests.InMemoryCachingScenarios.given_an_empty_in_memory_cache
{
    public abstract class Context : ArrangeActAssert
    {
        protected InMemoryCache Cache;
        protected const string CacheName = "sample cacheData name";
        protected int NumberOfScavengesScheduled = 0;

        protected const int ItemsBeforeScavenging = 5;
        protected const int ItemsAfterScavenging = 1;

        protected Mock<IRecurringWorkScheduler> ExpirationMock;

        private Action scavengingAction;
        
        protected override void Arrange()
        {
            base.Arrange();

            var schedulerMock = new Mock<IManuallyScheduledWork>();
            schedulerMock.Setup(s => s.SetAction(It.IsAny<Action>()))
                .Callback((Action sa) => scavengingAction = sa);
            schedulerMock.Setup(s => s.ScheduleWork())
                .Callback(() =>
                {
                    ++NumberOfScavengesScheduled;
                    scavengingAction();
                });

            ExpirationMock = new Mock<IRecurringWorkScheduler>();
            ExpirationMock.Setup(e => e.SetAction(It.IsAny<Action>()))
                .Verifiable();
            ExpirationMock.Setup(e => e.Start())
                .Verifiable();

            Cache = new InMemoryCache(CacheName, ItemsBeforeScavenging, ItemsAfterScavenging,
                schedulerMock.Object, ExpirationMock.Object);
        }

        protected override void Teardown()
        {
            CachingTimeProvider.ResetTimeProvider();
            NumberOfScavengesScheduled = 0;
            base.Teardown();
        }
    }
}
