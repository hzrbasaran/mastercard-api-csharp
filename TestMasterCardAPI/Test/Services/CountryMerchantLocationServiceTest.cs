﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MasterCard.SDK;
using MasterCard.SDK.Services.Location;
using MasterCard.SDK.Services.Location.Domain;

using Test.Services.Util;

namespace Test.Services
{
    [TestClass]
    public class CountryMerchantLocationServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private CountryMerchantLocationService service;

        [TestInitialize]
        public void Init()
        {
            this.service = new CountryMerchantLocationService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestService()
        {
            Countries countries = service.GetCountries();
            Assert.IsTrue(countries != null && countries.Country.Count > 0);
        }
    }
}
