using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Test.Services.Util;
using MasterCard.SDK;
using MasterCard.SDK.Services.PartnerWallet;
//using MasterCard.SDK.Services.PartnerWallet.Domain;
using MasterCard.SDK.Services.PartnerWallet.Domain.WalletStorage;

namespace Test.Services
{
    [TestClass]
    public class WalletStorageRewardProgramServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private WalletStorageRewardProgramService service;

        [TestInitialize]
        public void Init()
        {
            service = new WalletStorageRewardProgramService(Environments.Environment.SANDBOX, testUtils.GetConsumerKey(), testUtils.GetPrivateKey());
        }

        [TestMethod]
        public void TestMethod1()
        {
            RewardProgram rewardProgram = new RewardProgram();
            rewardProgram.ProgramID = "areward";
            rewardProgram.Number = 1234567890123456;
            rewardProgram.ExpiryMonth = "05";
            rewardProgram.ExpiryYear = "2016";
            
            service.CreateRewardProgram("16qmlkd3vtvmhjdtcpcdvuidhiqhrb1r2suu24k3oln2c0i95hf8", "1dqajif7octqpq43grt3m910lrkqnhle1d5g7h3svb3fl85ejf88", rewardProgram);
            service.GetRewardProgram("16qmlkd3vtvmhjdtcpcdvuidhiqhrb1r2suu24k3oln2c0i95hf8","1dqajif7octqpq43grt3m910lrkqnhle1d5g7h3svb3fl85ejf88","um25en82ahaht65ipattd3871khnf7keitss7crmprng32n6u0f");
        }
    }
}
