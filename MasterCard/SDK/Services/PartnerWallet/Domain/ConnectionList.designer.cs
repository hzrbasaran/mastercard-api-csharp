// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.37595
//    <NameSpace>csharp_mastercardapi</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
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
    public partial class ConnectionList
    {

        private List<ConnectionListConnection> connectionField;

        public ConnectionList()
        {
            this.connectionField = new List<ConnectionListConnection>();
        }

        [System.Xml.Serialization.XmlElementAttribute("Connection", Order = 0)]
        public List<ConnectionListConnection> Connection
        {
            get
            {
                return this.connectionField;
            }
            set
            {
                this.connectionField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConnectionListConnection
    {

        private int connectionIdField;

        private string merchantNameField;

        private ConnectionListConnectionLogo logoField;

        private string dataTypesField;

        private string oneClickSupportedField;

        private string oneClickEnabledField;

        private string lastUpdatedUsedField;

        private string connectedSinceDateField;

        private string expirationDateField;

        private string merchantUrlField;

        public ConnectionListConnection()
        {
            this.logoField = new ConnectionListConnectionLogo();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int ConnectionId
        {
            get
            {
                return this.connectionIdField;
            }
            set
            {
                this.connectionIdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string MerchantName
        {
            get
            {
                return this.merchantNameField;
            }
            set
            {
                this.merchantNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ConnectionListConnectionLogo Logo
        {
            get
            {
                return this.logoField;
            }
            set
            {
                this.logoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string DataTypes
        {
            get
            {
                return this.dataTypesField;
            }
            set
            {
                this.dataTypesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string OneClickSupported
        {
            get
            {
                return this.oneClickSupportedField;
            }
            set
            {
                this.oneClickSupportedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string OneClickEnabled
        {
            get
            {
                return this.oneClickEnabledField;
            }
            set
            {
                this.oneClickEnabledField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string LastUpdatedUsed
        {
            get
            {
                return this.lastUpdatedUsedField;
            }
            set
            {
                this.lastUpdatedUsedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string ConnectedSinceDate
        {
            get
            {
                return this.connectedSinceDateField;
            }
            set
            {
                this.connectedSinceDateField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string ExpirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string MerchantUrl
        {
            get
            {
                return this.merchantUrlField;
            }
            set
            {
                this.merchantUrlField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConnectionListConnectionLogo
    {

        private string urlField;

        private string alternateTextField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string AlternateText
        {
            get
            {
                return this.alternateTextField;
            }
            set
            {
                this.alternateTextField = value;
            }
        }
    }
}
