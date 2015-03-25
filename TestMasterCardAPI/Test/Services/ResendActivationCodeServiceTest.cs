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
    public class ResendActivationCodeServiceTest
    {
        private TestUtils testUtils = new TestUtils(Environments.Environment.SANDBOX);
        private MappingSearchService mappingSearchService;
        private DeliveryChannelsService deliveryChannelsService;
        private ResendActivationCodeService resendActivationCodeService;
        private SearchRequest searchRequest;
        private searchResponse response;
        private DeliveryChannels deliveryChannels;
        private ResendRequest resendRequest;
        private ResendCodeResults resendCodeResults;

        [TestInitialize]
        public void Init()
        {
            mappingSearchService = new MappingSearchService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
            deliveryChannelsService = new DeliveryChannelsService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
            resendActivationCodeService = new ResendActivationCodeService(testUtils.GetConsumerKey(), testUtils.GetPrivateKey(), Environments.Environment.SANDBOX);
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
            String tokenUniqueId = response.Devices.ElementAt(0).TokenUniqueId;
            deliveryChannels = deliveryChannelsService.GetDeliveryChannels(tokenUniqueId);
            long deliveryChannelId = deliveryChannels.DeliveryChannel.ElementAt(0).Id;
            resendRequest = new ResendRequest();
            resendRequest.DeliveryChannelId = deliveryChannelId;
            resendRequest.AuditInfo.UserId = "testUser";
            resendRequest.AuditInfo.UserName = "Test User";
            resendRequest.AuditInfo.Organization = "Test Org";
            resendCodeResults = resendActivationCodeService.GetResendCodeResults(resendRequest, tokenUniqueId);
            Assert.IsNotNull(resendCodeResults.ResponseCode);

        }
    }
}
