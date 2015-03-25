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
    public class CountrySubdivisionAtmLocationServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private CountrySubdivisionAtmLocationService service;

        [TestInitialize]
        public void Init()
        {
            this.service = new CountrySubdivisionAtmLocationService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestMethod1()
        {
            CountrySubdivisions countrySubdivisions = service.GetCountrySubdivisions(
                new CountrySubdivisionAtmLocationRequestOptions("USA")
            );
            Assert.IsTrue(countrySubdivisions != null && countrySubdivisions.CountrySubdivision.Count > 0);
        }
    }
}
