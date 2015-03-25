using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

using MasterCard.SDK;
using MasterCard.SDK.Services.MerchantIdentifier;
using MasterCard.SDK.Services.MerchantIdentifier.Domain;
using MasterCard.SDK.Services.MerchantIdentifier.Domain.Options;

using Test.Services.Util;

namespace Test.Services
{
    [TestClass]
    public class MerchantIdentifier_UnitTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private MerchantIdentifierService service;
        private MerchantIdentifierRequestOptions options;

        [TestInitialize]
        public void Init()
        {
            service = new MerchantIdentifierService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestMerchantIdentifierServiceByMerchantId_ExactMatch()
        {
            options = new MerchantIdentifierRequestOptions("DIRECTSATELLITETV");
            options.Type = "ExactMatch";
            MerchantIds merchantIds = service.GetMerchantId(options);
            Assert.IsTrue(merchantIds.ReturnedMerchants != null);
        }

        [TestMethod]
        public void TestMerchantIdentifierServiceByMerchantId_FuzzyMatch()
        {
            options = new MerchantIdentifierRequestOptions("DIRECTSATELLITETV");
            options.Type = "FuzzyMatch";
            MerchantIds merchantIds = service.GetMerchantId(options);
            Assert.IsTrue(merchantIds.ReturnedMerchants != null);
        }
    }
}
