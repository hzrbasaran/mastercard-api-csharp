﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using MasterCard.SDK;
using MasterCard.SDK.Services.Location.Domain;
using MasterCard.SDK.Services.Location.Domain.Options;
using MasterCard.SDK.Util;

namespace MasterCard.SDK.Services.Location
{
    public class AtmLocationService : Connector
    {
        private Environments.Environment environment;

        private readonly string PRODUCTION_URL = "https://api.mastercard.com/atms/v1/atm?Format=XML";
        private readonly string SANDBOX_URL = "https://sandbox.api.mastercard.com/atms/v1/atm?Format=XML";

        public AtmLocationService(string consumerKey, AsymmetricAlgorithm privateKey, Environments.Environment environment)
            : base(consumerKey, privateKey)
        {
            this.environment = environment;
        }

        public Atms GetAtms(AtmLocationRequestOptions options)
        {
            string response = "";
            Dictionary<string, string> responseMap = doRequest(GetURL(options), "GET", null);
            responseMap.TryGetValue(MESSAGE, out response);
            return Serializer<Atms>.Deserialize(response);
        }

        private string GetURL(AtmLocationRequestOptions options)
        {
            string url;
            if (this.environment == Environments.Environment.PRODUCTION)
            {
                url = PRODUCTION_URL;
            }
            else
            {
                url = SANDBOX_URL;
            }
            url = URLUtil.AddQueryParameter(url, "PageOffset", options.getPageOffset().ToString(), false, null);
            url = URLUtil.AddQueryParameter(url, "PageLength", options.getPageLength().ToString(), false, null);
            url = URLUtil.AddQueryParameter(url, "AddressLine1", options.AddressLine1, true, "");
            url = URLUtil.AddQueryParameter(url, "AddressLine2", options.AddressLine2, true, "");
            url = URLUtil.AddQueryParameter(url, "City", options.City, true, "");
            url = URLUtil.AddQueryParameter(url, "CountrySubdivision", options.CountrySubdivision, true, "");
            url = URLUtil.AddQueryParameter(url, "PostalCode", options.PostalCode, true, "");
            url = URLUtil.AddQueryParameter(url, "Country", options.Country, true, "");
            url = URLUtil.AddQueryParameter(url, "Latitude", options.Latitude.ToString(), true, "0");
            url = URLUtil.AddQueryParameter(url, "Longitude", options.Longitude.ToString(), true, "0");
            url = URLUtil.AddQueryParameter(url, "DistanceUnit", options.DistanceUnit, true, "");
            url = URLUtil.AddQueryParameter(url, "Radius", options.Radius.ToString(), true, "0");
            url = URLUtil.AddQueryParameter(url, "SupportEMV", options.SupportEMV.ToString(), true, "-1");
            return url;
        }
    }
}
