using MasterCard.SDK.Services.Restaurants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using MasterCard.SDK;
using MasterCard.SDK.Services.Restaurants.Domain;

using Test.Services.Util;

namespace MasterCard.SDK.Services.RestaurantsTest
{
    [TestClass]
    public class CountriesLocalFavoritesServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private CountriesLocalFavoritesService service;

        [TestInitialize]
        public void Init()
        {
            this.service = new CountriesLocalFavoritesService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestGetCountries()
        {
            var countries = service.GetCountries();
            Assert.IsTrue(countries != null && countries.CountryList.Count > 0);
        }
    }
}
