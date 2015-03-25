using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MasterCard.SDK;
using MasterCard.SDK.Services.Location;
using MasterCard.SDK.Services.Location.Domain;

using Test.Services.Util;

namespace Test.Services
{
    [TestClass]
    public class MerchantCategoriesServiceTest
    {

        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        MerchantCategoriesService service;

        [TestInitialize]
        public void Init()
        {
            service = new MerchantCategoriesService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }
 
        [TestMethod]
        public void TestService()
        {
            Categories categories = service.GetCategories();
            Assert.IsTrue(categories != null && categories.Category.Count > 0);
        }
    }
}
