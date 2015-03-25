using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

using MasterCard.SDK;
using MasterCard.SDK.Services.PartnerWallet.Domain;

namespace MasterCard.SDK.Services.PartnerWallet
{
    class ConnectedMerchantHistoryService : Connector
    {
        private readonly Environments.Environment environment;

        private const string SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/connectedmerchanthistory?Format=XML";
        private const string PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/connectedmerchanthistory?Format=XML";
        private const string MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/connectedmerchanthistory?Format=XML";

        public ConnectedMerchantHistoryService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }

        public ConnectionHistory GetConnectedHistory(ConnectionHistoryRequest request)
        {
            string response = ""; 
            Dictionary<string, string> responseMap = doRequest(getURL(), "POST", Serializer<ConnectionHistoryRequest>.Serialize(request).InnerXml);
            responseMap.TryGetValue(MESSAGE, out response);
            return Serializer<ConnectionHistory>.Deserialize(response);
        }

        private String getURL()
        {
            if (this.environment == Environments.Environment.PRODUCTION)
            {
                return PRODUCTION_URL;
            }
            else if (this.environment == Environments.Environment.MTF)
            {
                return MTF_URL;
            }
            else
            {
                return SANDBOX_URL;
            }
        }
    }
}
