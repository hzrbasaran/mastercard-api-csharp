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
    public class ProvisioningServiceTest
    {
        GeneralizedProvisioningRequest generalizedProvisioningRequest;
        Response response;
        ProvisioningService service;
        TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);

        [TestInitialize]
        public void Init()
        {
            service = new ProvisioningService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestService()
        {
            generalizedProvisioningRequest = new GeneralizedProvisioningRequest();
            generalizedProvisioningRequest.CurrentPan = 5112345678901255;
            generalizedProvisioningRequest.SecureElementId = "10000000000000061001000333c0000237a5a89708b18e45";
            generalizedProvisioningRequest.Action = "suspend";
            generalizedProvisioningRequest.Comments = "Wallet Service Provider suspended the account on 11/10/2013";
            generalizedProvisioningRequest.ReasonCode = "RC2";
            generalizedProvisioningRequest.AuditInfo.UserId = "testUser";
            generalizedProvisioningRequest.AuditInfo.UserName = "Test User";
            generalizedProvisioningRequest.AuditInfo.Organization = "Test Org";
            response = service.GetResponse(generalizedProvisioningRequest);
            Assert.IsNotNull(response.statusCode);
        }
    }
}
