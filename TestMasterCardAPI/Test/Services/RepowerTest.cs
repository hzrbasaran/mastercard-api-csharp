using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using MasterCard.SDK.Services.RepowerService;
using MasterCard.SDK.Services.RepowerService.Domain;
using MasterCard.SDK.Services.RepowerReversalService;
using MasterCard.SDK.Services.RepowerReversalService.Domain;
using MasterCard.SDK;

using Test.Services.Util;

namespace Test.Services
{
    [TestClass]
    public class RepowerTest
    {
        private RepowerService repowerService;
        private RepowerReversalService repowerReversalService;
        private RepowerRequest repowerRequest;
        private RepowerReversalRequest repowerReversalRequest;
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);

        [TestInitialize]
        public void Init()
        {
            repowerService = new RepowerService(Environments.Environment.SANDBOX, testUtils.GetConsumerKey(), testUtils.GetPrivateKey());
            repowerRequest = new RepowerRequest();
            repowerReversalService = new RepowerReversalService(Environments.Environment.SANDBOX, testUtils.GetConsumerKey(), testUtils.GetPrivateKey());
            repowerReversalRequest = new RepowerReversalRequest();
        }

        [TestMethod]
        public void RepowerService_Test()
        {
            // presumably negligible chance that this will result in a duplicate reference number
            long referenceNumber = 1000000000000000000;
            long staticNumber = 8999999999999999999;
            referenceNumber += (long)Math.Abs(((long)new Random().Next()) % staticNumber);
            
            //load
            repowerRequest.TransactionReference = referenceNumber.ToString();
            repowerRequest.CardNumber = 5184680430000006;
            repowerRequest.TransactionAmount.Value = 30000;
            repowerRequest.TransactionAmount.Currency = "840";
            repowerRequest.LocalDate = "1230";
            repowerRequest.LocalTime = "092435";
            repowerRequest.Channel = "W";
            repowerRequest.ICA = "009674";
            repowerRequest.ProcessorId = 9000000442;
            repowerRequest.RoutingAndTransitNumber = 990442082;
            repowerRequest.MerchantType = 6532;
            repowerRequest.CardAcceptor.Name = "Prepaid Load Store";
            repowerRequest.CardAcceptor.City = "St Charles";
            repowerRequest.CardAcceptor.State = "MO";
            repowerRequest.CardAcceptor.PostalCode = "63301";
            repowerRequest.CardAcceptor.Country = "USA";
            Repower repower = repowerService.getRepower(repowerRequest);

            // reverse load
            repowerReversalRequest.ReversalReason = "UNIT TEST";
            repowerReversalRequest.TransactionReference = referenceNumber.ToString();
            repowerReversalRequest.ICA = "009674";
            RepowerReversal reversal = repowerReversalService.getRepowerReveral(repowerReversalRequest);

            //submitting reversal again
            RepowerReversal reversal2 = repowerReversalService.getRepowerReveral(repowerReversalRequest);

            // reversing an already reversed transaction should return original reversal transaction data
            Assert.IsTrue(reversal.TransactionHistory.Transaction.SettlementDate.Equals(reversal2.TransactionHistory.Transaction.SettlementDate));
            Assert.IsTrue(reversal.TransactionHistory.Transaction.Type.Equals(reversal2.TransactionHistory.Transaction.Type));
            Assert.IsTrue(reversal.TransactionHistory.Transaction.NetworkReferenceNumber.Equals(reversal2.TransactionHistory.Transaction.NetworkReferenceNumber));
            Assert.IsTrue(reversal.TransactionHistory.Transaction.Response.Code.Equals(reversal2.TransactionHistory.Transaction.Response.Code));
            Assert.IsTrue(reversal.TransactionHistory.Transaction.SubmitDateTime.Equals(reversal2.TransactionHistory.Transaction.SubmitDateTime));
            Assert.IsTrue(reversal.TransactionHistory.Transaction.SystemTraceAuditNumber.Equals(reversal2.TransactionHistory.Transaction.SystemTraceAuditNumber));
        }
    }
}
