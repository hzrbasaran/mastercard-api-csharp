﻿using MasterCard.SDK.Services.PartnerWallet.Domain;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MasterCard.SDK.Services.PartnerWallet
{
    public class DeletePairingService : Connector
    {
        private readonly Environments.Environment environment;

        private const string SANDBOX_URL = "https://sandbox.api.mastercard.com/masterpass/partner/v6/deletepairing?Format=XML";
        private const string PRODUCTION_URL = "https://api.mastercard.com/masterpass/partner/v6/deletepairing?Format=XML";
        private const string MTF_URL = "https://api.mastercard.com/mtf/masterpass/partner/v6/deletepairing?Format=XML";

        public DeletePairingService(Environments.Environment environment, string consumerKey, AsymmetricAlgorithm privateKey)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }

        public Connection DeletePairing(DeletePairingRequest request)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(getURL(), "POST", Serializer<DeletePairingRequest>.Serialize(request).InnerXml);
            responseMap.TryGetValue(MESSAGE, out response);
            return Serializer<Connection>.Deserialize(response); 
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
