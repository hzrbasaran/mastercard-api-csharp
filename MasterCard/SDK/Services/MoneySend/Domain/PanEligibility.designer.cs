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


    public partial class PanEligibility
    {
        [XmlElementAttribute(Order = 1)]
        private int? requestIdField;

        private PanEligibilitySendingEligibility sendingEligibilityField;

        private PanEligibilityReceivingEligibility receivingEligibilityField;

        public PanEligibility()
        {
            this.receivingEligibilityField = new PanEligibilityReceivingEligibility();
            this.sendingEligibilityField = new PanEligibilitySendingEligibility();
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

        public PanEligibilitySendingEligibility SendingEligibility
        {
            get
            {
                return this.sendingEligibilityField;
            }
            set
            {
                this.sendingEligibilityField = value;
            }
        }

        public PanEligibilityReceivingEligibility ReceivingEligibility
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
    }

    public partial class PanEligibilitySendingEligibility
    {

        private Boolean eligibleField;

        private String reasonCodeField;

        private long? accountNumberField;

        private String iCAField;

        private PanEligibilitySendingEligibilityCurrency currencyField;

        private PanEligibilitySendingEligibilityCountry countryField;

        private PanEligibilitySendingEligibilityBrand brandField;

        public PanEligibilitySendingEligibility()
        {
            this.brandField = new PanEligibilitySendingEligibilityBrand();
            this.countryField = new PanEligibilitySendingEligibilityCountry();
            this.currencyField = new PanEligibilitySendingEligibilityCurrency();
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

        public String ReasonCode
        {
            get
            {
                return this.reasonCodeField;
            }
            set
            {
                this.reasonCodeField = value;
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

        public PanEligibilitySendingEligibilityCurrency Currency
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

        public PanEligibilitySendingEligibilityCountry Country
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

        public PanEligibilitySendingEligibilityBrand Brand
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

    public partial class PanEligibilitySendingEligibilityCurrency
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

    public partial class PanEligibilitySendingEligibilityCountry
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

    public partial class PanEligibilitySendingEligibilityBrand
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

    public partial class PanEligibilityReceivingEligibility
    {

        private Boolean eligibleField;

        private long? accountNumberField;

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
    }
}
