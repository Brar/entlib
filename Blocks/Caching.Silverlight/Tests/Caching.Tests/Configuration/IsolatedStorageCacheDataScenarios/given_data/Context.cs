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
using Microsoft.Practices.EnterpriseLibrary.Caching.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.TestSupport.ContextBase;
using Microsoft.Practices.EnterpriseLibrary.Caching.IsolatedStorage;

namespace Microsoft.Practices.EnterpriseLibrary.Caching.Tests.Configuration.IsolatedStorageCacheDataScenarios.given_data
{
    public abstract class Context : ArrangeActAssert
    {
        public class MockSerializer : IIsolatedStorageCacheEntrySerializer
        {
            public byte[] Serialize(IsolatedStorageCacheEntry entry)
            {
                throw new NotImplementedException();
            }

            public IsolatedStorageCacheEntry Deserialize(byte[] serializedEntry)
            {
                throw new NotImplementedException();
            }

            public EntryUpdate GetUpdateForLastUpdateTime(IsolatedStorageCacheEntry entry)
            {
                throw new NotImplementedException();
            }
        }

        protected IsolatedStorageCacheData data;

        protected override void Arrange()
        {
            base.Arrange();

            this.data = new IsolatedStorageCacheData 
                { 
                    Name = "test name", 
                    MaxSizeInKilobytes = 100, 
                    PercentOfQuotaUsedBeforeScavenging = 75, 
                    PercentOfQuotaUsedAfterScavenging = 65, 
                    ExpirationPollingInterval = TimeSpan.FromSeconds(45),
                    SerializerType = typeof(MockSerializer)
                };
        }
    }
}
