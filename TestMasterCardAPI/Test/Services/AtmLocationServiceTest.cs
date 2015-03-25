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
    public class AtmLocationServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private AtmLocationService service;
        private AtmLocationRequestOptions options;

        [TestInitialize]
        public void Init()
        {
            service = new AtmLocationService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
            options = new AtmLocationRequestOptions(0, 25);
        }

        [TestMethod]
        public void TestGetByNumericPostalCode()
        {
            options.PostalCode = "46320";
            options.Country = "USA";
            Atms atms = service.GetAtms(options);
            Assert.IsTrue(atms != null && atms.Atm.Count > 0);
        }

        [TestMethod]
        public void TestGetByForeignPostalCode()
        {
            options.PostalCode = "068897";
            options.Country = "SGP";
            Atms atms = service.GetAtms(options);
            Assert.IsTrue(atms != null && atms.Atm.Count > 0);
        }

        [TestMethod]
        public void TestGetByAlphaNumericPostalCode()
        {
            options.PostalCode = "60606-6301";
            options.Country = "USA";
            Atms atms = service.GetAtms(options);
            Assert.IsTrue(atms != null && atms.Atm.Count > 0);
        }

        [TestMethod]
        public void TestByLatLong()
        {
            options.Latitude = 1.2833;
            options.Longitude = 103.8499;
            options.Radius = 5;
            options.DistanceUnit = AtmLocationRequestOptions.KILOMETER;
            Atms atms = service.GetAtms(options);
            Assert.IsTrue(atms != null && atms.Atm.Count > 0);
        }

        [TestMethod]
        public void TestByAddress()
        {
            options.AddressLine1 = "BLK 1 ROCHOR ROAD UNIT 01-640 ROCHOR ROAD";
            options.Country = "SGP";
            Atms atms = service.GetAtms(options);
            Assert.IsTrue(atms != null && atms.Atm.Count > 0);
        }

        [TestMethod]
        public void TestByCity()
        {
            options.City = "CHICAGO";
            options.Country = "USA";
            Atms atms = service.GetAtms(options);
            Assert.IsTrue(atms != null && atms.Atm.Count > 0);
        }

        [TestMethod]
        public void TestByCountrySubdivision()
        {
            options.CountrySubdivision = "IL";
            options.Country = "USA";
            Atms atms = service.GetAtms(options);
            Assert.IsTrue(atms != null && atms.Atm.Count > 0);
        }

        [TestMethod]
        public void TestBySupportEMV()
        {
            options.SupportEMV = AtmLocationRequestOptions.SUPPORT_EMV_YES;
            options.Latitude = 1.2833;
            options.Longitude = 103.8499;
            Atms atms = service.GetAtms(options);
            Assert.IsTrue(atms != null && atms.Atm.Count > 0);
        }
    }
}
