﻿#region license
// ==============================================================================
// Microsoft patterns & practices Enterprise Library
// aExpense Reference Implementation
// ==============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
// ==============================================================================
#endregion

using AExpense.DataAccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace AExpense.Tests.Util
{
    public static class ProfileStoreHelper
    {
        private static readonly DatabaseProviderFactory dbFactory = new DatabaseProviderFactory(ConfigurationSourceFactory.Create());

        public static SimulatedLdapProfileStore GetProfileStore(string database)
        {
            var db = dbFactory.Create(database);

            return new SimulatedLdapProfileStore(db);
        }
    }
}
