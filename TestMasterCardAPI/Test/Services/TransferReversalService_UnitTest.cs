using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterCard.SDK.Services.MoneySend;
using MasterCard.SDK;
using MasterCard.SDK.Services.MoneySend.Domain;

using Test.Services.Util;

namespace Test.Services
{
    [TestClass]
    public class TransferReversalService_UnitTest
    {
        TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        TransferReversalService service;

        [TestInitialize]
        public void Init()
        {
            service = new TransferReversalService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestTransferReversalRequest()
        {
            TransferReversalRequest request = new TransferReversalRequest();
            request.ICA = "009674";
            request.TransactionReference = 4000000002010101031L;
            request.ReversalReason = "FAILURE IN PROCESSING";
            TransferReversal transferReversal = service.GetTransferReversal(request);
            Assert.IsTrue(transferReversal != null);
            Assert.IsTrue(transferReversal.RequestId > 0);
            Assert.IsTrue(transferReversal.TransactionReference > 0);
            Assert.IsTrue(transferReversal.TransactionHistory.Transaction != null);
        }
        
    }
}
