using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Services.Util;
using MasterCard.SDK;
using MasterCard.SDK.Services.Common;

namespace Test.Services
{
    [TestClass]
    public class RequestTokenServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private RequestTokenService service;

        [TestInitialize]
        public void Init()
        {
            service = new RequestTokenService(Environments.Environment.SANDBOX, testUtils.GetConsumerKey(), testUtils.GetPrivateKey());
        }

        [TestMethod]
        public void TestService()
        {
            var response = service.GetRequestTokenReponse("http://testsite.com");
            
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.RequestToken);
        }
    }
}
