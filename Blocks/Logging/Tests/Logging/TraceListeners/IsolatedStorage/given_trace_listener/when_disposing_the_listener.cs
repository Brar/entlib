﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Logging Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using Microsoft.Silverlight.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Tests.TraceListeners.IsolatedStorage.given_trace_listener
{
    [TestClass]
    [Tag("IsolatedStorage")]
    public class when_disposing_the_listener : Context
    {
        protected override void Act()
        {
            this.traceListener.Dispose();
        }

        [TestMethod]
        public void then_repository_is_not_disposed()
        {
            this.repositoryMock.Verify(r => r.Dispose(), Times.Never());
        }
    }
}
