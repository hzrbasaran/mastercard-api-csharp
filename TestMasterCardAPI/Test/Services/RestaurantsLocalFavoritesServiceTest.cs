using MasterCard.SDK.Services.Restaurants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using MasterCard.SDK;
using MasterCard.SDK.Services.Restaurants.Domain.Options;
using MasterCard.SDK.Services.Restaurants.Domain;

using Test.Services.Util;

namespace MasterCard.SDK.Services.RestaurantsTest
{
    [TestClass]
    public class RestaurantsLocalFavoritesServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private RestaurantsLocalFavoritesService service;

        [TestInitialize]
        public void Init()
        {
            this.service = new RestaurantsLocalFavoritesService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestGetCountrySubdivisions()
        {
            var options = new RestaurantsLocalFavoritesOptions(0, 10);
            options.Latitude = 38.53463;
            options.Longitude = -90.286781;
            var restaurants = service.GetRestaurants(options);
            Assert.IsTrue(restaurants != null && restaurants.RestaurantList.Count > 0);
        }
    }
}
