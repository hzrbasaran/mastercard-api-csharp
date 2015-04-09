using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using MasterCard.SDK.Services.PartnerWallet.Domain.RewardProgramOfferings;

namespace MasterCard.SDK.Services.PartnerWallet
{
    public class RewardProgramOfferingsService : Connector
    {
        private readonly Environments.Environment environment;

        private const string SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/reward-program-offerings?Format=XML";
        private const string PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/reward-program-offerings?Format=XML";
        private const string MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/reward-program-offerings?Format=XML";

        public RewardProgramOfferingsService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }

        public rewardProgramOfferingsResponse GetRewardProgramOfferingResponse()
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(getURL(), "GET");
            responseMap.TryGetValue(MESSAGE, out response);
            return Serializer<rewardProgramOfferingsResponse>.Deserialize(response);
        }

        private String getURL()
        {
            string url;
            if (this.environment == Environments.Environment.PRODUCTION)
            {
                url = PRODUCTION_URL;
            }
            else if (this.environment == Environments.Environment.MTF)
            {
                url = MTF_URL;
            }
            else
            {
                url = SANDBOX_URL;
            }

            return url;
        }
    }
}
