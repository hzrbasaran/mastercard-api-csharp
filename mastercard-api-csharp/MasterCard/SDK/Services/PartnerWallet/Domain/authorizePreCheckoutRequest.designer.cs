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
    public partial class AuthorizePrecheckoutRequest
    {

        private AuthorizePrecheckoutRequestPrecheckoutData precheckoutDataField;

        public AuthorizePrecheckoutRequest()
        {
            this.precheckoutDataField = new AuthorizePrecheckoutRequestPrecheckoutData();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AuthorizePrecheckoutRequestPrecheckoutData PrecheckoutData
        {
            get
            {
                return this.precheckoutDataField;
            }
            set
            {
                this.precheckoutDataField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizePrecheckoutRequestPrecheckoutData
    {

        private AuthorizePrecheckoutRequestPrecheckoutDataCards cardsField;

        private AuthorizePrecheckoutRequestPrecheckoutDataContact contactField;

        private AuthorizePrecheckoutRequestPrecheckoutDataShippingAddresses shippingAddressesField;

        private string walletIdField;

        private string precheckoutTransactionIdField;

        private long consumerWalletIdField;

        public AuthorizePrecheckoutRequestPrecheckoutData()
        {
            this.shippingAddressesField = new AuthorizePrecheckoutRequestPrecheckoutDataShippingAddresses();
            this.contactField = new AuthorizePrecheckoutRequestPrecheckoutDataContact();
            this.cardsField = new AuthorizePrecheckoutRequestPrecheckoutDataCards();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AuthorizePrecheckoutRequestPrecheckoutDataCards Cards
        {
            get
            {
                return this.cardsField;
            }
            set
            {
                this.cardsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public AuthorizePrecheckoutRequestPrecheckoutDataContact Contact
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
        public AuthorizePrecheckoutRequestPrecheckoutDataShippingAddresses ShippingAddresses
        {
            get
            {
                return this.shippingAddressesField;
            }
            set
            {
                this.shippingAddressesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string WalletId
        {
            get
            {
                return this.walletIdField;
            }
            set
            {
                this.walletIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string PrecheckoutTransactionId
        {
            get
            {
                return this.precheckoutTransactionIdField;
            }
            set
            {
                this.precheckoutTransactionIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public long ConsumerWalletId
        {
            get
            {
                return this.consumerWalletIdField;
            }
            set
            {
                this.consumerWalletIdField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizePrecheckoutRequestPrecheckoutDataCards
    {

        private AuthorizePrecheckoutRequestPrecheckoutDataCardsCard cardField;

        public AuthorizePrecheckoutRequestPrecheckoutDataCards()
        {
            this.cardField = new AuthorizePrecheckoutRequestPrecheckoutDataCardsCard();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AuthorizePrecheckoutRequestPrecheckoutDataCardsCard Card
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizePrecheckoutRequestPrecheckoutDataCardsCard
    {

        private string brandIdField;

        private string brandNameField;

        private AuthorizePrecheckoutRequestPrecheckoutDataCardsCardBillingAddress billingAddressField;

        private string cardHolderNameField;

        private string expiryMonthField;

        private string expiryYearField;

        private long cardIdField;

        private long lastFourField;

        private string cardAliasField;

        private string selectedAsDefaultField;

        public AuthorizePrecheckoutRequestPrecheckoutDataCardsCard()
        {
            this.billingAddressField = new AuthorizePrecheckoutRequestPrecheckoutDataCardsCardBillingAddress();
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
        public AuthorizePrecheckoutRequestPrecheckoutDataCardsCardBillingAddress BillingAddress
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public long CardId
        {
            get
            {
                return this.cardIdField;
            }
            set
            {
                this.cardIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public long LastFour
        {
            get
            {
                return this.lastFourField;
            }
            set
            {
                this.lastFourField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string CardAlias
        {
            get
            {
                return this.cardAliasField;
            }
            set
            {
                this.cardAliasField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string SelectedAsDefault
        {
            get
            {
                return this.selectedAsDefaultField;
            }
            set
            {
                this.selectedAsDefaultField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizePrecheckoutRequestPrecheckoutDataCardsCardBillingAddress
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
    public partial class AuthorizePrecheckoutRequestPrecheckoutDataContact
    {

        private string firstNameField;

        private string middleNameField;

        private string lastNameField;

        private string genderField;

        private AuthorizePrecheckoutRequestPrecheckoutDataContactDateOfBirth dateOfBirthField;

        private long nationalIDField;

        private string countryField;

        private string emailAddressField;

        private string phoneNumberField;

        public AuthorizePrecheckoutRequestPrecheckoutDataContact()
        {
            this.dateOfBirthField = new AuthorizePrecheckoutRequestPrecheckoutDataContactDateOfBirth();
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
        public AuthorizePrecheckoutRequestPrecheckoutDataContactDateOfBirth DateOfBirth
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
        public string PhoneNumber
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
    public partial class AuthorizePrecheckoutRequestPrecheckoutDataContactDateOfBirth
    {

        private long yearField;

        private long monthField;

        private long dayField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public long Year
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
        public long Month
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
        public long Day
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
    public partial class AuthorizePrecheckoutRequestPrecheckoutDataShippingAddresses
    {

        private AuthorizePrecheckoutRequestPrecheckoutDataShippingAddressesShippingAddress shippingAddressField;

        public AuthorizePrecheckoutRequestPrecheckoutDataShippingAddresses()
        {
            this.shippingAddressField = new AuthorizePrecheckoutRequestPrecheckoutDataShippingAddressesShippingAddress();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public AuthorizePrecheckoutRequestPrecheckoutDataShippingAddressesShippingAddress ShippingAddress
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AuthorizePrecheckoutRequestPrecheckoutDataShippingAddressesShippingAddress
    {

        private string cityField;

        private string countryField;

        private string countrySubdivisionField;

        private string line1Field;

        private long postalCodeField;

        private string recipientNameField;

        private string recipientPhoneNumberField;

        private long addressIdField;

        private string selectedAsDefaultField;

        private string shippingAliasField;

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
        public long PostalCode
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public long AddressId
        {
            get
            {
                return this.addressIdField;
            }
            set
            {
                this.addressIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string SelectedAsDefault
        {
            get
            {
                return this.selectedAsDefaultField;
            }
            set
            {
                this.selectedAsDefaultField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string ShippingAlias
        {
            get
            {
                return this.shippingAliasField;
            }
            set
            {
                this.shippingAliasField = value;
            }
        }
    }
}
