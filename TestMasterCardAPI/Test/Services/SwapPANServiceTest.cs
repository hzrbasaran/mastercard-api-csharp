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
    public class SwapPANServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private SwapPANService service;
        private SwapPANRequest request;
        private Responses response;

        [TestInitialize]
        public void Init()
        {
            service = new SwapPANService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestService()
        {
            request = new SwapPANRequest();
            request.CurrentPan = 5112345678901255;
            request.NewPan.Id = 5112345678901235;
            request.NewPan.ExpiryDate = "0917";
            request.NewPan.CardSequenceNumber = "001";
            request.NewPan.UpdateWalletServiceProvider = 0;
            request.Comments = "Issuer swaped the account on 01/03/2014";
            request.AuditInfo.UserId = "testUser";
            request.AuditInfo.UserName = "Test User";
            request.AuditInfo.Organization = "Test Org";
            response = service.GetResponses(request);
            Assert.IsNotNull(response.Response);
        }
    }
}
