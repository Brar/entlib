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

using System.Management;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Manageability;
using Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Practices.EnterpriseLibrary.Caching.Configuration.Manageability.Tests
{
	[TestClass]
	public class UnknownCacheManagerSettingFixture
	{
		[TestInitialize]
		public void SetUp()
		{
			ManagementEntityTypesRegistrar.SafelyRegisterTypes(typeof(UnknownCacheManagerSetting));
			NamedConfigurationSetting.ClearPublishedInstances();
		}

		[TestCleanup]
		public void TearDown()
		{
			ManagementEntityTypesRegistrar.UnregisterAll();
			NamedConfigurationSetting.ClearPublishedInstances();
		}

		[TestMethod]
		public void WmiQueryReturnsEmptyResultIfNoPublishedInstances()
		{
			using (System.Management.ManagementObjectCollection.ManagementObjectEnumerator resultEnumerator
				= new ManagementObjectSearcher("root\\enterpriselibrary", "SELECT * FROM UnknownCacheManagerSetting")
						.Get().GetEnumerator())
			{
				Assert.IsFalse(resultEnumerator.MoveNext());
			}
		}
		
		[TestMethod]
		public void CanBindObject()
		{
			UnknownCacheManagerSetting setting = new UnknownCacheManagerSetting("name");
			
			setting.ApplicationName = "app";
			setting.SectionName = InstrumentationConfigurationSection.SectionName;
			//setting.Changed += this.Changed;

			setting.Publish();

			using (System.Management.ManagementObjectCollection.ManagementObjectEnumerator resultEnumerator
				= new ManagementObjectSearcher("root\\enterpriselibrary", "SELECT * FROM UnknownCacheManagerSetting")
					.Get().GetEnumerator())
			{
				Assert.IsTrue(resultEnumerator.MoveNext());
				Assert.AreEqual("UnknownCacheManagerSetting", resultEnumerator.Current.SystemProperties["__CLASS"].Value);

				ManagementObject managementObject = resultEnumerator.Current as ManagementObject;
				Assert.IsNotNull(managementObject);

				//should throw 
				managementObject.Put();
			}
		}
	}
}
