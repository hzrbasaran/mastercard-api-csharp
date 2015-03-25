using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterCard.SDK.Services.MoneySend;
using MasterCard.SDK;
using MasterCard.SDK.Services.MoneySend.Domain;

using Test.Services.Util;

namespace Test.Services
{
    [TestClass]
    public class DeleteSubscriberIdService_UnitTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private DeleteSubscriberIdService service;

        [TestInitialize]
        public void Init()
        {
            service = new DeleteSubscriberIdService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestDeleteSubscriberIdRequest()
        {
            DeleteSubscriberIdRequest deleteSubscriberIdRequest = new DeleteSubscriberIdRequest();
            deleteSubscriberIdRequest.SubscriberId = "example@email.com";
            deleteSubscriberIdRequest.SubscriberType = "PHONE_NUMBER";
            DeleteSubscriberId deleteSubscriberId = service.GetDeleteSubscriberId(deleteSubscriberIdRequest);
            Assert.IsTrue(deleteSubscriberId != null);
        }

    }
}
