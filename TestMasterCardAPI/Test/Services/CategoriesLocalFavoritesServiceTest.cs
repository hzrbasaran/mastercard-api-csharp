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
    public class CategoriesLocalFavoritesServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private CategoriesLocalFavoritesService service;

        [TestInitialize]
        public void Init()
        {
            this.service = new CategoriesLocalFavoritesService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestGetCategories()
        {
            var categories = service.GetCategories();
            Assert.IsTrue(categories != null && categories.CategoryList.Count > 0);
        }
    }
}
