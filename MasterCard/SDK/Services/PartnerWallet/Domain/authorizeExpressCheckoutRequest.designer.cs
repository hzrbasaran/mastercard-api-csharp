// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.37595
//    <NameSpace>MasterCard.SDK.Services.PartnerWallet.Domain</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace MasterCard.SDK.Services.PartnerWallet.Domain
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class AuthorizeExpressCheckoutRequest
    {

        private string preCheckoutTransactionIdField;

        private string currencyCodeField;

        private int orderAmountField;

        private string merchantParameterIdField;

        private string oAuthTokenField;

        private AuthorizeExpressCheckoutRequestAuthorizedExpressCheckout authorizedExpressCheckoutField;

        private string originUrlField;

        private string deviceTypeField;

        public AuthorizeExpressCheckoutRequest()
        {
            this.authorizedExpressCheckoutField = new AuthorizeExpressCheckoutRequestAuthorizedExpressCheckout();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string PreCheckoutTransactionId
        {
            get
            {
                return this.preCheckoutTransactionIdField;
            }
            set
            {
                this.preCheckoutTransactionIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public int OrderAmount
        {
            get
            {
                return this.orderAmountField;
            }
            set
            {
                this.orderAmountField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string MerchantParameterId
        {
            get
            {
                return this.merchantParameterIdField;
            }
            set
            {
                this.merchantParameterIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string OAuthToken
        {
            get
            {
                return this.oAuthTokenField;
            }
            set
            {
                this.oAuthTokenField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public AuthorizeExpressCheckoutRequestAuthorizedExpressCheckout AuthorizedExpressCheckout
        {
            get
            {
                return this.authorizedExpressCheckoutField;
            }
            set
            {
                this.authorizedExpressCheckoutField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string OriginUrl
        {
            get
            {
                return this.originUrlField;
            }
            set
            {
                this.originUrlField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string DeviceType
        {
            get
            {
                return this.deviceTypeField;
            }
            set
            {
                this.deviceTypeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizeExpressCheckoutRequestAuthorizedExpressCheckout
    {

        private AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutCard cardField;

        private AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutContact contactField;

        private AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutShippingAddress shippingAddressField;

        private object rewardProgramField;

        public AuthorizeExpressCheckoutRequestAuthorizedExpressCheckout()
        {
            this.shippingAddressField = new AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutShippingAddress();
            this.contactField = new AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutContact();
            this.cardField = new AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutCard();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutCard Card
        {
            get
            {
                return this.cardField;
            }
            set
            {
                this.cardField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutContact Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutShippingAddress ShippingAddress
        {
            get
            {
                return this.shippingAddressField;
            }
            set
            {
                this.shippingAddressField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public object RewardProgram
        {
            get
            {
                return this.rewardProgramField;
            }
            set
            {
                this.rewardProgramField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutCard
    {

        private string brandIdField;

        private string brandNameField;

        private long accountNumberField;

        private AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutCardBillingAddress billingAddressField;

        private string cardHolderNameField;

        private string expiryMonthField;

        private string expiryYearField;

        public AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutCard()
        {
            this.billingAddressField = new AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutCardBillingAddress();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string BrandId
        {
            get
            {
                return this.brandIdField;
            }
            set
            {
                this.brandIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string BrandName
        {
            get
            {
                return this.brandNameField;
            }
            set
            {
                this.brandNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public long AccountNumber
        {
            get
            {
                return this.accountNumberField;
            }
            set
            {
                this.accountNumberField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutCardBillingAddress BillingAddress
        {
            get
            {
                return this.billingAddressField;
            }
            set
            {
                this.billingAddressField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string CardHolderName
        {
            get
            {
                return this.cardHolderNameField;
            }
            set
            {
                this.cardHolderNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string ExpiryMonth
        {
            get
            {
                return this.expiryMonthField;
            }
            set
            {
                this.expiryMonthField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string ExpiryYear
        {
            get
            {
                return this.expiryYearField;
            }
            set
            {
                this.expiryYearField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutCardBillingAddress
    {

        private string cityField;

        private string countryField;

        private string countrySubdivisionField;

        private string line1Field;

        private string postalCodeField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CountrySubdivision
        {
            get
            {
                return this.countrySubdivisionField;
            }
            set
            {
                this.countrySubdivisionField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Line1
        {
            get
            {
                return this.line1Field;
            }
            set
            {
                this.line1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutContact
    {

        private string firstNameField;

        private string middleNameField;

        private string lastNameField;

        private string genderField;

        private AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutContactDateOfBirth dateOfBirthField;

        private long nationalIDField;

        private string countryField;

        private string emailAddressField;

        private long phoneNumberField;

        public AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutContact()
        {
            this.dateOfBirthField = new AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutContactDateOfBirth();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutContactDateOfBirth DateOfBirth
        {
            get
            {
                return this.dateOfBirthField;
            }
            set
            {
                this.dateOfBirthField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public long NationalID
        {
            get
            {
                return this.nationalIDField;
            }
            set
            {
                this.nationalIDField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string EmailAddress
        {
            get
            {
                return this.emailAddressField;
            }
            set
            {
                this.emailAddressField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public long PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutContactDateOfBirth
    {

        private string yearField;

        private string monthField;

        private string dayField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Month
        {
            get
            {
                return this.monthField;
            }
            set
            {
                this.monthField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string Day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizeExpressCheckoutRequestAuthorizedExpressCheckoutShippingAddress
    {

        private string cityField;

        private string countryField;

        private string countrySubdivisionField;

        private string line1Field;

        private string postalCodeField;

        private string recipientNameField;

        private string recipientPhoneNumberField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CountrySubdivision
        {
            get
            {
                return this.countrySubdivisionField;
            }
            set
            {
                this.countrySubdivisionField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string Line1
        {
            get
            {
                return this.line1Field;
            }
            set
            {
                this.line1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string RecipientName
        {
            get
            {
                return this.recipientNameField;
            }
            set
            {
                this.recipientNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string RecipientPhoneNumber
        {
            get
            {
                return this.recipientPhoneNumberField;
            }
            set
            {
                this.recipientPhoneNumberField = value;
            }
        }
    }
}
