using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterCard.SDK;
using MasterCard.SDK.Services.MDES;
using MasterCard.SDK.Services.MDES.Domain;

using Test.Services.Util;

namespace Test.Services
{
    [TestClass]
    public class SystemStatusServiceTest
    {

        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private SystemStatusService service;

        [TestInitialize]
        public void Init()
        {
            service = new SystemStatusService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestService()
        {
            systemStatusResponses systemStatusResponses = service.GetSystemStatusResponses();
            Assert.IsNotNull(systemStatusResponses.SystemResponse);
        }
    }
}
