using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MasterCard.SDK;
using MasterCard.SDK.Services.PartnerWallet.Domain.WalletStorage;
using System.Security.Cryptography;

namespace MasterCard.SDK.Services.PartnerWallet.WalletStorage
{
    public class WalletStorageShippingAddressService : Connector
    {
        private readonly Environments.Environment environment;

        private const string GET_PUT_DELETE_SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/shipping-address/<shipping_address_id>?Format=XML";
        private const string GET_PUT_DELETE_PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/shipping-address/<shipping_address_id>?Format=XML";
        private const string GET_PUT_DELETE_MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/shipping-address/<shipping_address_id>?Format=XML";

        private const string POST_SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/shipping-address?Format=XML";
        private const string POST_PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/shipping-address?Format=XML";
        private const string POST_MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/shipping-address?Format=XML";

        public WalletStorageShippingAddressService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }
            
        public ShippingAddress GetShippingAddress(string walletProviderId, string walletId, string shippingAddressId)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetGetPutDeleteURL(walletProviderId, walletId, shippingAddressId), "GET");
            responseMap.TryGetValue(MESSAGE, out response);
            Console.WriteLine(response);
            return null; //Serializer<RewardProgram>.Deserialize(response);
        }

        public string CreateShippingAddress(string walletProviderId, string walletId, ShippingAddress shippingAddress)
        {
            string response = "";
            Console.WriteLine(Serializer<ShippingAddress>.Serialize(shippingAddress).InnerXml);
            Dictionary<string, string> responseMap = doRequest(GetPostURL(walletProviderId, walletId), "POST", Serializer<ShippingAddress>.Serialize(shippingAddress).InnerXml);
            responseMap.TryGetValue(MESSAGE, out response);
            Console.WriteLine(response);
            return null; // Serializer<CardBrandsResponse>.Deserialize(response);
        }

        public string UpdateShippingAddress(string walletProviderId, string walletId, string shippingAddressId, ShippingAddress shippingAddress)
        {
            string response = "";
            Console.WriteLine(Serializer<ShippingAddress>.Serialize(shippingAddress).InnerXml);
            Dictionary<string, string> responseMap = doRequest(GetGetPutDeleteURL(walletProviderId, walletId, shippingAddressId), "PUT", Serializer<ShippingAddress>.Serialize(shippingAddress).InnerXml);
            responseMap.TryGetValue(MESSAGE, out response);
            Console.WriteLine(response);
            return null; // Serializer<CardBrandsResponse>.Deserialize(response);
        }

        public string DeleteShippingAddress(string walletProviderId, string walletId, string shippingAddressId)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetGetPutDeleteURL(walletProviderId, walletId, shippingAddressId), "DELETE");
            responseMap.TryGetValue(MESSAGE, out response);
            Console.WriteLine(response);
            return null; // Serializer<CardBrandsResponse>.Deserialize(response);
        }

        private String GetGetPutDeleteURL(string walletProviderId, string walletId, string shippingAddressId)
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
            url = url.Replace("<shipping_address_id>", shippingAddressId);

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
