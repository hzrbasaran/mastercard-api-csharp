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
    public class DeliveryChannelsServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private MappingSearchService mappingSearchService;
        private DeliveryChannelsService deliveryChannelsService;
        private SearchRequest searchRequest;
        private searchResponse response;
        private DeliveryChannels deliveryChannels;

        [TestInitialize]
        public void Init()
        {
            mappingSearchService = new MappingSearchService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
            deliveryChannelsService = new DeliveryChannelsService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
        }

        [TestMethod]
        public void TestService()
        {
            searchRequest = new SearchRequest();
            searchRequest.Pan = 5112345678901234;
            searchRequest.AuditInfo.UserId = "testUser";
            searchRequest.AuditInfo.UserName = "Test User";
            searchRequest.AuditInfo.Organization = "Test Org";
            response = mappingSearchService.GetSearchResponse(searchRequest);
            string tokenUniqueId = response.Devices.ElementAt(0).TokenUniqueId;
            deliveryChannels = deliveryChannelsService.GetDeliveryChannels(tokenUniqueId);
            Assert.IsNotNull(deliveryChannels.DeliveryChannel);
        }
    }
}
