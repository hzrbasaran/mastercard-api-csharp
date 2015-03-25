using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Services.Util;
using MasterCard.SDK.Services.PartnerWallet;
using MasterCard.SDK;
using MasterCard.SDK.Services.PartnerWallet.Domain;

namespace Test.Services
{
    [TestClass]
    public class CardBrandsServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private CardBrandsService service;

        [TestInitialize]
        public void Init()
        {
            service = new CardBrandsService(Environments.Environment.SANDBOX, testUtils.GetConsumerKey(), testUtils.GetPrivateKey());
        }

        [TestMethod]
        public void TestService()
        {
            CardBrandsRequest request = new CardBrandsRequest { Country = "US", Language = "en" };
            var response = service.GetCardBrandsResponse(request);
            Assert.IsNotNull(response.CardBrands);
            Assert.IsTrue(response.CardBrands.Count > 0);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(response.CardBrands[0].Name));
        }
    }
}
