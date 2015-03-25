using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

using MasterCard.SDK;
using MasterCard.SDK.Services.PartnerWallet.Domain.WalletStorage;

namespace MasterCard.SDK.Services.PartnerWallet
{
    public class WalletStorageRewardProgramService : Connector
    {
        private readonly Environments.Environment environment;

        private const string GET_PUT_DELETE_SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/reward-program/<reward_program_id>?Format=XML";
        private const string GET_PUT_DELETE_PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/reward-program/<reward_program_id>?Format=XML";
        private const string GET_PUT_DELETE_MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/reward-program/<reward_program_id>?Format=XML";

        private const string POST_SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/reward-program?Format=XML";
        private const string POST_PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/reward-program?Format=XML";
        private const string POST_MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/wallet-provider/<wallet_provider_id>/wallet/<wallet_id>/reward-program?Format=XML";

        public WalletStorageRewardProgramService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }
            
        public RewardProgram GetRewardProgram(string walletProviderId, string walletId, string rewardProgramId)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetGetPutDeleteURL(walletProviderId, walletId, rewardProgramId), "GET");
            responseMap.TryGetValue(MESSAGE, out response);
            Console.WriteLine(response);
            return Serializer<RewardProgram>.Deserialize(response);
        }

        public string CreateRewardProgram(string walletProviderId, string walletId, RewardProgram rewardProgram)
        {
            string response = "";
            Console.WriteLine(Serializer<RewardProgram>.Serialize(rewardProgram).InnerXml);
            Dictionary<string, string> responseMap = doRequest(GetPostURL(walletProviderId, walletId), "POST", Serializer<RewardProgram>.Serialize(rewardProgram).InnerXml);
            responseMap.TryGetValue(MESSAGE, out response);
            Console.WriteLine(response);
            return null; // Serializer<CardBrandsResponse>.Deserialize(response);
        }

        public string UpdateRewardProgram(string walletProviderId, string walletId, string rewardProgramId, RewardProgram rewardProgram)
        {
            string response = "";
            Console.WriteLine(Serializer<RewardProgram>.Serialize(rewardProgram).InnerXml);
            Dictionary<string, string> responseMap = doRequest(GetGetPutDeleteURL(walletProviderId, walletId, rewardProgramId), "PUT", Serializer<RewardProgram>.Serialize(rewardProgram).InnerXml);
            responseMap.TryGetValue(MESSAGE, out response);
            Console.WriteLine(response);
            return null; // Serializer<CardBrandsResponse>.Deserialize(response);
        }

        public string DeleteRewardProgram(string walletProviderId, string walletId, string rewardProgramId)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetGetPutDeleteURL(walletProviderId, walletId, rewardProgramId), "DELETE");
            responseMap.TryGetValue(MESSAGE, out response);
            Console.WriteLine(response);
            return null; // Serializer<CardBrandsResponse>.Deserialize(response);
        }

        private string GetGetPutDeleteURL(string walletProviderId, string walletId, string rewardProgramId)
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
            url = url.Replace("<reward_program_id>", rewardProgramId);

            return url;
        }

        private string GetPostURL(string walletProviderId, string walletId)
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
