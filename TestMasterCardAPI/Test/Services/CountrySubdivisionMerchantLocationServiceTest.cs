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
    public class CountrySubdivisionMerchantLocationServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private CountrySubdivisionMerchantLocationService service;

        [TestInitialize]
        public void Init()
        {
            this.service = new CountrySubdivisionMerchantLocationService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestAcceptancePaypass()
        {
            CountrySubdivisions countrySubdivisions = service.GetCountrySubdivisions(
                new CountrySubdivisionMerchantLocationRequestOptions(Details.ACCEPTANCE_PAYPASS, "USA")
            );
            Assert.IsTrue(countrySubdivisions != null && countrySubdivisions.CountrySubdivision.Count > 0);
        }

        [TestMethod]
        public void TestFeaturesCashback()
        {
            CountrySubdivisions countrySubdivisions = service.GetCountrySubdivisions(
                new CountrySubdivisionMerchantLocationRequestOptions(Details.FEATURES_CASHBACK, "USA")
            );
            Assert.IsTrue(countrySubdivisions != null && countrySubdivisions.CountrySubdivision.Count > 0);
        }

        [TestMethod]
        public void TestOffersEasysavings()
        {
            CountrySubdivisions countrySubdivisions = service.GetCountrySubdivisions(
                new CountrySubdivisionMerchantLocationRequestOptions(Details.OFFERS_EASYSAVINGS, "USA")
            );
            Assert.IsTrue(countrySubdivisions != null && countrySubdivisions.CountrySubdivision.Count > 0);
        }

        [TestMethod]
        public void TestProductsPrepaidTravelCard()
        {
            CountrySubdivisions countrySubdivisions = service.GetCountrySubdivisions(
                new CountrySubdivisionMerchantLocationRequestOptions(Details.PRODUCTS_PREPAID_TRAVEL_CARD, "USA")
            );
            Assert.IsTrue(countrySubdivisions != null && countrySubdivisions.CountrySubdivision.Count > 0);
        }

        [TestMethod]
        public void TestTopupRepower()
        {
            CountrySubdivisions countrySubdivisions = service.GetCountrySubdivisions(
                new CountrySubdivisionMerchantLocationRequestOptions(Details.TOPUP_REPOWER, "USA")
            );
            Assert.IsTrue(countrySubdivisions != null && countrySubdivisions.CountrySubdivision.Count > 0);
        }
    }
}
