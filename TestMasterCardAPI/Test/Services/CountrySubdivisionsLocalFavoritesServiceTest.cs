using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MasterCard.SDK.Services.Restaurants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterCard.SDK.Services.Restaurants.Domain.Options;
using MasterCard.SDK.Services.Restaurants.Domain;

using Test.Services.Util;

namespace MasterCard.SDK.Services.RestaurantsTest
{
    [TestClass]
    public class CountrySubdivisionsLocalFavoritesServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private CountrySubdivisionsLocalFavoritesService service;

        [TestInitialize]
        public void Init()
        {
            this.service = new CountrySubdivisionsLocalFavoritesService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]    
        public void TestGetCountrySubdivisions()
        {
            CountrySubdivisions countrySubdivisions = service.GetCountrySubdivisions(
                new CountrySubdivisionsLocalFavoritesOptions("USA")
            );
            Assert.IsTrue(countrySubdivisions != null && countrySubdivisions.CountrySubdivisionList.Count > 0);
        }
    }
}
