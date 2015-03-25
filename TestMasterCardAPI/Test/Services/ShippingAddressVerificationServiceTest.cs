//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using MasterCard.SDK.Services.PartnerWallet;
//using Test.Services.Util;
//using MasterCard.SDK;
//using MasterCard.SDK.Services.Common;
//using MasterCard.SDK.Services.PartnerWallet.Domain;

//namespace Test.Services
//{
//    [TestClass]
//    public class ShippingAddressVerificationServiceTest
//    {
//        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
//        private ShippingAddressVerificationService service;
//        private string oAuthToken;

//        [TestInitialize]
//        public void Init()
//        {
//            service = new ShippingAddressVerificationService(Environments.Environment.SANDBOX, testUtils.GetConsumerKey(), testUtils.GetPrivateKey());
//            oAuthToken = new RequestTokenService(Environments.Environment.SANDBOX, testUtils.GetConsumerKey(), testUtils.GetPrivateKey()).GetRequestTokenReponse().RequestToken;
//        }

//        [TestMethod]
//        public void TestService()
//        {
//            var serviceRequest = new ShippingAddressVerificationRequest();
//            serviceRequest.OAuthToken = oAuthToken;
//            serviceRequest.VerifiableAddresses = new VerifiableAddresses { VerifiableAddress = new List<VerifiableAddress>() };
//            serviceRequest.VerifiableAddresses.VerifiableAddress.Add(new VerifiableAddress { Country = "US", CountrySubdivision = "US-VA" });
//            serviceRequest.VerifiableAddresses.VerifiableAddress.Add(new VerifiableAddress { Country = "US", CountrySubdivision = "US-MD" });
//            var serviceResponse = service.GetShippingAddressVerificationResponse(serviceRequest);

//            Assert.IsNotNull(serviceResponse.VerificationResults);
//            Assert.AreEqual(2, serviceResponse.VerificationResults.VerificationResult.Count);
//            Assert.IsTrue(serviceResponse.VerificationResults.VerificationResult.First(r => r.CountrySubdivision == "US-VA").Accepted);
//            Assert.IsFalse(serviceResponse.VerificationResults.VerificationResult.First(r => r.CountrySubdivision == "US-XX").Accepted);
//        }
//    }
//}
