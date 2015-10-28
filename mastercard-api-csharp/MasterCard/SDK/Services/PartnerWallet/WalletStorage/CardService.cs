using MasterCard.SDK.Services.PartnerWallet.Domain.WalletStorage;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MasterCard.SDK.Services.PartnerWallet.WalletStorage
{
    public class CardService : Connector
    {
        private readonly Environments.Environment environment;

        private const string GET_PUT_DELETE_SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/card/<card_id>?Format=XML";
        private const string GET_PUT_DELETE_PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/card/<card_id>?Format=XML";
        private const string GET_PUT_DELETE_MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/card/<card_id>?Format=XML";

        private const string POST_SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/card?Format=XML";
        private const string POST_PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/card?Format=XML";
        private const string POST_MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/card?Format=XML";

        public CardService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }

        public Card GetCard(string walletProviderId, string walletId, string cardId)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetGetPutDeleteURL(walletProviderId, walletId, cardId), "GET", null);
            responseMap.TryGetValue(MESSAGE, out response);
            return Serializer<Card>.Deserialize(response);
        }

        public String CreateCard(string walletProviderId, string walletId, Card card)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetPostURL(walletProviderId, walletId), "POST", Serializer<Card>.Serialize(card).InnerXml);
            responseMap.TryGetValue(MESSAGE, out response);
            return response;
        }

        public String UpdateCard(string walletProviderId, string walletId, string cardId, Card card)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetGetPutDeleteURL(walletProviderId, walletId, cardId), "PUT", Serializer<Card>.Serialize(card).InnerXml);
            responseMap.TryGetValue(MESSAGE, out response);
            Console.WriteLine(response);
            return response;
        }

        public String DeleteCard(string walletProviderId, string walletId, string cardId)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetGetPutDeleteURL(walletProviderId, walletId, cardId), "DELETE", null);
            responseMap.TryGetValue(MESSAGE, out response);
            return response;
        }

        private String GetGetPutDeleteURL(string walletProviderId, string walletId, string cardId)
        {
            string url;
            if (this.environment == Environments.Environment.PRODUCTION)
            {
                url = GET_PUT_DELETE_PRODUCTION_URL;
            }
            else if (this.environment == Environments.Environment.MTF)
            {
                url = GET_PUT_DELETE_MTF_URL;
            }
            else
            {
                url = GET_PUT_DELETE_SANDBOX_URL;
            }

            url = url.Replace("<wallet_provider_id>", walletProviderId);
            url = url.Replace("<wallet_id>", walletId);
            url = url.Replace("<card_id>", cardId);

            return url;
        }

        private String GetPostURL(string walletProviderId, string walletId)
        {
            string url;
            if (this.environment == Environments.Environment.PRODUCTION)
            {
                url = POST_PRODUCTION_URL;
            }
            else if (this.environment == Environments.Environment.MTF)
            {
                url = POST_MTF_URL;
            }
            else
            {
                url = POST_SANDBOX_URL;
            }

            url = url.Replace("<wallet_provider_id>", walletProviderId);
            url = url.Replace("<wallet_id>", walletId);

            return url;
        }
    }
}
