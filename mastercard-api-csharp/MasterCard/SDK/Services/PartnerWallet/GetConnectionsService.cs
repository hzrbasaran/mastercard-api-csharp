using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using MasterCard.SDK.Services.PartnerWallet.Domain.SwitchAPI;

namespace MasterCard.SDK.Services.PartnerWallet
{
    public class GetConnectionsService : Connector
    {
        private readonly Environments.Environment environment;

        private const string SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/connectedmerchants?Format=XML";
        private const string PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/connectedmerchants?Format=XML";
        private const string MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/connectedmerchants?Format=XML";

        public GetConnectionsService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }

        public ConnectionList GetConnectionList(ConnectedMerchantsRequest request)
        {
            string response = ""; 
            Dictionary<string, string> responseMap = doRequest(getURL(), "POST", Serializer<ConnectedMerchantsRequest>.Serialize(request).InnerXml);
            responseMap.TryGetValue(MESSAGE, out response);
            return Serializer<ConnectionList>.Deserialize(response); 
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
