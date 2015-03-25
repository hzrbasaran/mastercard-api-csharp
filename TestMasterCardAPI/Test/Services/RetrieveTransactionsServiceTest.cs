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
    public class RetrieveTransactionsServiceTest
    {

        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private RetrieveTransactionsService service;
        private TransactionRequest request;
        private deviceTransaction response;

        [TestInitialize]
        public void Init()
        {
            service = new RetrieveTransactionsService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestService()
        {
            request = new TransactionRequest();
            request.TokenUniqueId = "DWSPMC00000000010906a349d9ca4eb1a4d53e3c90a11d9c";
            request.AuditInfo.UserId = "testUser";
            request.AuditInfo.UserName = "Test User";
            request.AuditInfo.Organization = "Test Org";
            response = service.GetDeviceTransaction(request);
            Assert.IsNotNull(response.Transactions);
        }
    }
}
