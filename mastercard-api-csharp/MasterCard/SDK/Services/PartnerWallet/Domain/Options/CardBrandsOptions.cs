using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartnerWalletSDK.Services.PartnerWallet.Domain.Options
{
    public class CardBrandsOptions
    {
        public String Language { get; set; }
        public String Country { get; set; }

        public CardBrandsOptions(String language, String country)
        {
            this.Language = language;
            this.Country = country;
        }
    }
}
