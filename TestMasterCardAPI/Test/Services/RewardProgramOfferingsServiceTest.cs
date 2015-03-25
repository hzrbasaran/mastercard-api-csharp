using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Services.Util;
using MasterCard.SDK.Services.PartnerWallet;
using MasterCard.SDK;

namespace Test.Services
{
    [TestClass]
    public class RewardProgramOfferingsServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private RewardProgramOfferingsService service;

        [TestInitialize]
        public void Init()
        {
            service = new RewardProgramOfferingsService(Environments.Environment.SANDBOX, testUtils.GetConsumerKey(), testUtils.GetPrivateKey());
        }

        [TestMethod]
        public void TestService()
        {
            var rewardOffering = service.GetRewardProgramOfferingResponse();
            Assert.IsNotNull(rewardOffering);
            Assert.IsNotNull(rewardOffering.RewardProgramOfferings);
            Assert.IsNotNull(rewardOffering.RewardProgramOfferings[0].Id);
            Assert.IsNotNull(rewardOffering.RewardProgramOfferings[0].Name);
        }
    }
}
