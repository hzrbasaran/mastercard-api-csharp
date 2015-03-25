// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.37595
//    <NameSpace>moneysend</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace MasterCard.SDK.Services.MoneySend.Domain
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    public partial class InquireMapping
    {
        [XmlElementAttribute(Order = 1)]
        private int? requestIdField;

        private List<InquireMappingMapping> mappingsField;

        public InquireMapping()
        {
            this.mappingsField = new List<InquireMappingMapping>();
        }

        public int? RequestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("Mapping", IsNullable = false)]
        public List<InquireMappingMapping> Mappings
        {
            get
            {
                return this.mappingsField;
            }
            set
            {
                this.mappingsField = value;
            }
        }
    }

    public partial class InquireMappingMapping
    {

        private int? mappingIdField;

        private String subscriberIdField;

        private String accountUsageField;

        private String defaultIndicatorField;

        private String aliasField;

        private String iCAField;

        private long? accountNumberField;

        private InquireMappingMappingCardholderFullName cardholderFullNameField;

        private InquireMappingMappingAddress addressField;

        private InquireMappingMappingReceivingEligibility receivingEligibilityField;

        private int? expiryDateField;

        public InquireMappingMapping()
        {
            this.receivingEligibilityField = new InquireMappingMappingReceivingEligibility();
            this.addressField = new InquireMappingMappingAddress();
            this.cardholderFullNameField = new InquireMappingMappingCardholderFullName();
        }

        public int? MappingId
        {
            get
            {
                return this.mappingIdField;
            }
            set
            {
                this.mappingIdField = value;
            }
        }

        public String SubscriberId
        {
            get
            {
                return this.subscriberIdField;
            }
            set
            {
                this.subscriberIdField = value;
            }
        }

        public String AccountUsage
        {
            get
            {
                return this.accountUsageField;
            }
            set
            {
                this.accountUsageField = value;
            }
        }

        public String DefaultIndicator
        {
            get
            {
                return this.defaultIndicatorField;
            }
            set
            {
                this.defaultIndicatorField = value;
            }
        }

        public String Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        public String ICA
        {
            get
            {
                return this.iCAField;
            }
            set
            {
                this.iCAField = value;
            }
        }

        public long? AccountNumber
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

        public InquireMappingMappingCardholderFullName CardholderFullName
        {
            get
            {
                return this.cardholderFullNameField;
            }
            set
            {
                this.cardholderFullNameField = value;
            }
        }

        public InquireMappingMappingAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        public InquireMappingMappingReceivingEligibility ReceivingEligibility
        {
            get
            {
                return this.receivingEligibilityField;
            }
            set
            {
                this.receivingEligibilityField = value;
            }
        }

        public int? ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }
    }

    public partial class InquireMappingMappingCardholderFullName
    {

        private String cardholderFirstNameField;

        private String cardholderMiddleNameField;

        private String cardholderLastNameField;

        public String CardholderFirstName
        {
            get
            {
                return this.cardholderFirstNameField;
            }
            set
            {
                this.cardholderFirstNameField = value;
            }
        }

        public String CardholderMiddleName
        {
            get
            {
                return this.cardholderMiddleNameField;
            }
            set
            {
                this.cardholderMiddleNameField = value;
            }
        }

        public String CardholderLastName
        {
            get
            {
                return this.cardholderLastNameField;
            }
            set
            {
                this.cardholderLastNameField = value;
            }
        }
    }

    public partial class InquireMappingMappingAddress
    {

        private String line1Field;

        private String cityField;

        private String countrySubdivisionField;

        private int? postalCodeField;

        private String countryField;

        public String Line1
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

        public String City
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

        public String CountrySubdivision
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

        public int? PostalCode
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

        public String Country
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
    }

    public partial class InquireMappingMappingReceivingEligibility
    {

        private Boolean eligibleField;

        private InquireMappingMappingReceivingEligibilityCurrency currencyField;

        private InquireMappingMappingReceivingEligibilityCountry countryField;

        private InquireMappingMappingReceivingEligibilityBrand brandField;

        public InquireMappingMappingReceivingEligibility()
        {
            this.brandField = new InquireMappingMappingReceivingEligibilityBrand();
            this.countryField = new InquireMappingMappingReceivingEligibilityCountry();
            this.currencyField = new InquireMappingMappingReceivingEligibilityCurrency();
        }

        public Boolean Eligible
        {
            get
            {
                return this.eligibleField;
            }
            set
            {
                this.eligibleField = value;
            }
        }

        public InquireMappingMappingReceivingEligibilityCurrency Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        public InquireMappingMappingReceivingEligibilityCountry Country
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

        public InquireMappingMappingReceivingEligibilityBrand Brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }
    }

    public partial class InquireMappingMappingReceivingEligibilityCurrency
    {

        private String alphaCurrencyCodeField;

        private int? numericCurrencyCodeField;

        public String AlphaCurrencyCode
        {
            get
            {
                return this.alphaCurrencyCodeField;
            }
            set
            {
                this.alphaCurrencyCodeField = value;
            }
        }

        public int? NumericCurrencyCode
        {
            get
            {
                return this.numericCurrencyCodeField;
            }
            set
            {
                this.numericCurrencyCodeField = value;
            }
        }
    }

    public partial class InquireMappingMappingReceivingEligibilityCountry
    {

        private String alphaCountryCodeField;

        private int? numericCountryCodeField;

        public String AlphaCountryCode
        {
            get
            {
                return this.alphaCountryCodeField;
            }
            set
            {
                this.alphaCountryCodeField = value;
            }
        }

        public int? NumericCountryCode
        {
            get
            {
                return this.numericCountryCodeField;
            }
            set
            {
                this.numericCountryCodeField = value;
            }
        }
    }

    public partial class InquireMappingMappingReceivingEligibilityBrand
    {

        private String acceptanceBrandCodeField;

        private String productBrandCodeField;

        public String AcceptanceBrandCode
        {
            get
            {
                return this.acceptanceBrandCodeField;
            }
            set
            {
                this.acceptanceBrandCodeField = value;
            }
        }

        public String ProductBrandCode
        {
            get
            {
                return this.productBrandCodeField;
            }
            set
            {
                this.productBrandCodeField = value;
            }
        }
    }
}
