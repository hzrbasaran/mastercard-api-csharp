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
    public class ReasonCodesServiceTest
    {

        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private ReasonCodesService service;

        [TestInitialize]
        public void Init()
        {
            service = new ReasonCodesService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestService()
        {
            reasonCodess reasonCodes = service.GetResponse();            
            Assert.IsNotNull(reasonCodes.ReasonCode);
        }
    }
}
