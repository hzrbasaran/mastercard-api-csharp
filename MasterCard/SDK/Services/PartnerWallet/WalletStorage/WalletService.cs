using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MasterCard.SDK;
using System.Security.Cryptography;
using MasterCard.SDK.Services.PartnerWallet.Domain.WalletStorage;
using MasterCard.SDK.Util;
using System.Globalization;
using MasterCard.SDK.Services.PartnerWallet.Domain;

namespace MasterCard.SDK.Services.PartnerWallet
{
    public class WalletService : Connector
    {
        private readonly Environments.Environment environment;

        private const string SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/wallet-provider/{0}/wallet/{1}?Format=XML";
        private const string PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/wallet-provider/{0}/wallet/{1}?Format=XML";
        private const string MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/wallet-provider/{0}/wallet/{1}?Format=XML";

        public WalletService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }
            
        public string CreateWallet(long walletProviderId)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetURL(walletProviderId), "POST");
            responseMap.TryGetValue(MESSAGE, out response);
            return response;
        }

        public Wallet ReadWallet(long walletProviderId, long walletId)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetURL(walletProviderId, walletId), "GET");
            responseMap.TryGetValue(MESSAGE, out response);
            return Serializer<Wallet>.Deserialize(response);
        }

        public void DeleteWallet(long walletProviderId, long walletId)
        {
            doRequest(GetURL(walletProviderId, walletId), "DELETE");
        }

        private string GetURL(long walletProviderId, long? walletId = null)
        {
            var cardId = walletId == null ? string.Empty : URLUtil.Encode(walletId.Value.ToString(CultureInfo.InvariantCulture));

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

            return string.Format(
                url,
                URLUtil.Encode(walletProviderId.ToString(CultureInfo.InvariantCulture)),
                cardId);
        }
    }
}