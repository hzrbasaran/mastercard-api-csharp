using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MasterCard.SDK;
using MasterCard.SDK.Services.MDES;
using MasterCard.SDK.Services.MDES.Domain;

using Test.Services.Util;

namespace Test.Services
{
    [TestClass]
    public class MappingSearchServiceTest
    {

        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private MappingSearchService service;
        private SearchRequest searchRequest;
        private searchResponse response;

        [TestInitialize]
        public void Init()
        {
            service = new MappingSearchService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }


        [TestMethod]
        public void TestService()
        {
            searchRequest = new SearchRequest();
            searchRequest.Pan = 5112345678901234;
            searchRequest.AuditInfo.UserId = "testUser";
            searchRequest.AuditInfo.UserName = "Test User";
            searchRequest.AuditInfo.Organization = "Test Org";
            response = service.GetSearchResponse(searchRequest);
            Assert.IsNotNull(response.PANDetails);
            Assert.IsNotNull(response.Response);
        }



    }
}
