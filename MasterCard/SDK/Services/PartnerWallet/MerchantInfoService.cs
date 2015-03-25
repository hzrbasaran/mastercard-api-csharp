using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MasterCard.SDK;
using System.Security.Cryptography;
using MasterCard.SDK.Util;
using MasterCard.SDK.Services.PartnerWallet.Domain;

namespace MasterCard.SDK.Services.PartnerWallet
{
    public class MerchantInfoService : Connector
    {
        private readonly Environments.Environment environment;

        private const string SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/merchant/{0}?Format=XML";
        private const string PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/merchant/{0}?Format=XML";
        private const string MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/merchant/{0}?Format=XML";

        public MerchantInfoService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }
            
        public Merchant GetMerchant(string merchantCheckoutId)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(getURL(merchantCheckoutId), "GET");
            responseMap.TryGetValue(MESSAGE, out response);
            return Serializer<Merchant>.Deserialize(response);
        }

        private String getURL(string merchantCheckoutId)
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

            url = string.Format(url, URLUtil.Encode(merchantCheckoutId));

            return url;
        }
    }
}
