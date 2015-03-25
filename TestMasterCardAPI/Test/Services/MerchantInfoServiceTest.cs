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
    public class MerchantInfoServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private MerchantInfoService service;

        [TestInitialize]
        public void Init()
        {
            service = new MerchantInfoService(Environments.Environment.SANDBOX, testUtils.GetConsumerKey(), testUtils.GetPrivateKey());
        }

        [TestMethod]
        public void TestService()
        {
            var merchant = service.GetMerchant("a4a6x1ywxlkxzhensyvad1hepuouaesuv");
            Assert.IsNotNull(merchant);
            Assert.IsNotNull(merchant.Logo.AlternateText);
            Assert.IsNotNull(merchant.Name);
            Assert.IsNotNull(merchant.ProductionUrl);
        }
    }
}
