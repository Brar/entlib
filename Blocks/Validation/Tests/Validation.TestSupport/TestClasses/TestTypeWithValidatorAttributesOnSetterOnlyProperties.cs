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
using System.Text;

namespace Microsoft.Practices.EnterpriseLibrary.Validation.TestSupport.TestClasses
{
	public class TestTypeWithValidatorAttributesOnSetterOnlyProperties
	{
		[MockValidator(false, MessageTemplate = "PropertyWithGetter")]
		public String PropertyWithGetter
		{
			get { return null; }
		}

		[MockValidator(false, MessageTemplate = "PropertyWithGetterAndSetter")]
		public String PropertyWithGetterAndSetter
		{
			get { return null; }
			set { }
		}

		[MockValidator(false, MessageTemplate = "PropertyWithSetter")]
		public String PropertyWithSetter
		{
			set { }
		}
	}
}
