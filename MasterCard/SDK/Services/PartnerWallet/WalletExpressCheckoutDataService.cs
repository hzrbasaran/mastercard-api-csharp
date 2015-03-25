using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MasterCard.SDK.Services.MDES.Domain;
using MasterCard.SDK.Services.PartnerWallet.Domain;
using System.Security.Cryptography;

namespace MasterCard.SDK.Services.PartnerWallet
{
    class WalletExpressCheckoutDataService : Connector
    {
        private readonly Environments.Environment environment;
        private readonly String walletUrl;

        private const string SANDBOX_URL = null;
        private const string PRODUCTION_URL = "https://<wallet_url>/walletapi/wallet/v6/expresscheckout?Format=XML";
        private const string MTF_URL = null;

        public WalletExpressCheckoutDataService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey, String walletUrl)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
            this.walletUrl = walletUrl;
        }

        public Response postRequest(WalletExpressCheckoutRequest request)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(getURL(), "POST", Serializer<WalletExpressCheckoutRequest>.Serialize(request).InnerXml);
            responseMap.TryGetValue(MESSAGE, out response);
            return Serializer<Response>.Deserialize(response); 
        }

        private string getURL()
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
            if (url != null)
            {
                url = url.Replace("<wallet_url>", walletUrl);
            }
            return url;
        }
    }
}
