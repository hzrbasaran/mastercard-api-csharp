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
    public class ActivateServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private ActivateService service;
        private ActivateRequest activateRequest;
        private Response response;

        [TestInitialize]
        public void Init()
        {
            service = new ActivateService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestService()
        {
            activateRequest = new ActivateRequest();
            activateRequest.Pan = 5112345678901255;
            activateRequest.SecureElementId = "10000000000000061001000333c0000237a5a89708b18e45";
            activateRequest.AuditInfo.UserId = "testUser";
            activateRequest.AuditInfo.UserName = "Test User";
            activateRequest.AuditInfo.Organization = "Test Org";
            response = service.GetResponse(activateRequest);
            Assert.IsNotNull(response.statusCode);
        }
    }
}
