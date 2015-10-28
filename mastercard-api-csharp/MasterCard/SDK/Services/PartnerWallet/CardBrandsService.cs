using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using MasterCard.SDK.Util;
using MasterCard.SDK.Services.PartnerWallet.Domain;

namespace MasterCard.SDK.Services.PartnerWallet
{
    public class CardBrandsService : Connector
    {
        private readonly Environments.Environment environment;

        private const string SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/card-brands?Format=XML";
        private const string PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/card-brands?Format=XML";
        private const string MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/card-brands?Format=XML";

        public CardBrandsService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }
            
        public CardBrandsResponse GetCardBrandsResponse(CardBrandsOptions request)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(getURL(request), "GET");
            responseMap.TryGetValue(MESSAGE, out response);
            return Serializer<CardBrandsResponse>.Deserialize(response);
        }

        private String getURL(CardBrandsOptions request)
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

            url = URLUtil.AddQueryParameter(url, "language", request.Language, false, null);
            url = URLUtil.AddQueryParameter(url, "country", request.Country, false, null);

            return url;
        }
    }
}
