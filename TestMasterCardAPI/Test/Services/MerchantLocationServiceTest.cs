using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MasterCard.SDK;
using MasterCard.SDK.Services.Location;
using MasterCard.SDK.Services.Location.Domain;
using MasterCard.SDK.Services.Location.Domain.Options;

using Test.Services.Util;

namespace Test.Services
{
    [TestClass]
    public class MerchantLocationServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private MerchantLocationService service;
        private MerchantLocationsRequestOptions options;

        [TestInitialize]
        public void Init()
        {
            service = new MerchantLocationService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestMerchantLocationServiceRepower()
        {
            options = new MerchantLocationsRequestOptions(Details.TOPUP_REPOWER, 0, 25);
            options.Country = "USA";
            options.PostalCode = "22122";
            Merchants merchants = service.GetMerchants(options);
            Assert.IsTrue(merchants != null && merchants.Merchant.Count > 0);
        }

        [TestMethod]
        public void TestMerchantLocationServicePrepaidTravelCardFail()
        {
            options = new MerchantLocationsRequestOptions(Details.PRODUCTS_PREPAID_TRAVEL_CARD, 0, 25);
            options.Country = "USA";
            options.PostalCode = "200006";
            Merchants merchants = service.GetMerchants(options);
            Assert.IsTrue(merchants != null && merchants.Merchant.Count > 0);
        }

        [TestMethod]
        public void TestMerchantLocationServicePrepaidTravelCardPass()
        {
            options = new MerchantLocationsRequestOptions(Details.PRODUCTS_PREPAID_TRAVEL_CARD, 0, 25);
            options.Country = "USA";
            options.PostalCode = "20006";
            Merchants merchants = service.GetMerchants(options);
            Assert.IsTrue(merchants != null && merchants.Merchant == null);
        }

        [TestMethod]
        public void TestMerchantLocationServiceOffers()
        {
            options = new MerchantLocationsRequestOptions(Details.OFFERS_EASYSAVINGS, 0, 25);
            options.Country = "USA";
            options.PostalCode = "22122";
            Merchants merchants = service.GetMerchants(options);
            Assert.IsTrue(merchants != null && merchants.Merchant.Count > 0);
        }

        [TestMethod]
        public void TestMerchantLocationServicePaypass()
        {
            options = new MerchantLocationsRequestOptions(Details.ACCEPTANCE_PAYPASS, 0, 25);
            options.PostalCode = "07032";
            options.Country = "USA";
            Merchants merchants = service.GetMerchants(options);
            Assert.IsTrue(merchants != null && merchants.Merchant.Count > 0);
        }

        [TestMethod]
        public void TestMerchantLocationServiceCashback()
        {
            options = new MerchantLocationsRequestOptions(Details.FEATURES_CASHBACK, 0, 25);
            options.PostalCode = "46323";
            options.Country = "USA";
            Merchants merchants = service.GetMerchants(options);
            Assert.IsTrue(merchants != null && merchants.Merchant.Count > 0);
        }

        [TestMethod]
        public void TestInternationalMaestroAccepted()
        {
            options = new MerchantLocationsRequestOptions(Details.FEATURES_CASHBACK, 0, 25);
            options.PostalCode = "46323";
            options.Country = "USA";
            options.SetInternationalMaestroAccepted(true);
            Merchants merchants = service.GetMerchants(options);
            Assert.IsTrue(merchants != null && merchants.Merchant.Count > 0);
        }
    }
}
