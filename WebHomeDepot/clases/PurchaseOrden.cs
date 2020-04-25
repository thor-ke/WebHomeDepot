namespace WebHomeDepot.clases
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PurchaseOrder
    {

        private string senderField;

        private PurchaseOrderPO poField;

        /// <remarks/>
        public string Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        /// <remarks/>
        public PurchaseOrderPO PO
        {
            get
            {
                return this.poField;
            }
            set
            {
                this.poField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PurchaseOrderPO
    {

        private byte pONumberField;

        private byte aSNField;

        private byte revNoField;

        private string dateField;

        private string dateRevField;

        private string dateDelivField;

        private string shipViaField;

        private string labField;

        private string backOrdersField;

        private string freigthTermsField;

        private string invoiceTermsField;

        private decimal totalCubeField;

        private decimal totalWeightField;

        private PurchaseOrderPOVendor vendorField;

        private byte storeReceivesField;

        private PurchaseOrderPOShipTo shipToField;

        private PurchaseOrderPOInstruction[] instructionsField;

        private PurchaseOrderPOItem[] itemsField;

        private byte totalQntyField;

        private decimal subTotalField;

        private byte ivaField;

        private PurchaseOrderPOTotal totalField;

        private PurchaseOrderPOInvoiceTo invoiceToField;

        private string statusField;

        /// <remarks/>
        public byte PONumber
        {
            get
            {
                return this.pONumberField;
            }
            set
            {
                this.pONumberField = value;
            }
        }

        /// <remarks/>
        public byte ASN
        {
            get
            {
                return this.aSNField;
            }
            set
            {
                this.aSNField = value;
            }
        }

        /// <remarks/>
        public byte RevNo
        {
            get
            {
                return this.revNoField;
            }
            set
            {
                this.revNoField = value;
            }
        }

        /// <remarks/>
        public string Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public string DateRev
        {
            get
            {
                return this.dateRevField;
            }
            set
            {
                this.dateRevField = value;
            }
        }

        /// <remarks/>
        public string DateDeliv
        {
            get
            {
                return this.dateDelivField;
            }
            set
            {
                this.dateDelivField = value;
            }
        }

        /// <remarks/>
        public string ShipVia
        {
            get
            {
                return this.shipViaField;
            }
            set
            {
                this.shipViaField = value;
            }
        }

        /// <remarks/>
        public string Lab
        {
            get
            {
                return this.labField;
            }
            set
            {
                this.labField = value;
            }
        }

        /// <remarks/>
        public string BackOrders
        {
            get
            {
                return this.backOrdersField;
            }
            set
            {
                this.backOrdersField = value;
            }
        }

        /// <remarks/>
        public string FreigthTerms
        {
            get
            {
                return this.freigthTermsField;
            }
            set
            {
                this.freigthTermsField = value;
            }
        }

        /// <remarks/>
        public string InvoiceTerms
        {
            get
            {
                return this.invoiceTermsField;
            }
            set
            {
                this.invoiceTermsField = value;
            }
        }

        /// <remarks/>
        public decimal TotalCube
        {
            get
            {
                return this.totalCubeField;
            }
            set
            {
                this.totalCubeField = value;
            }
        }

        /// <remarks/>
        public decimal TotalWeight
        {
            get
            {
                return this.totalWeightField;
            }
            set
            {
                this.totalWeightField = value;
            }
        }

        /// <remarks/>
        public PurchaseOrderPOVendor Vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        public byte StoreReceives
        {
            get
            {
                return this.storeReceivesField;
            }
            set
            {
                this.storeReceivesField = value;
            }
        }

        /// <remarks/>
        public PurchaseOrderPOShipTo ShipTo
        {
            get
            {
                return this.shipToField;
            }
            set
            {
                this.shipToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Instruction", IsNullable = false)]
        public PurchaseOrderPOInstruction[] Instructions
        {
            get
            {
                return this.instructionsField;
            }
            set
            {
                this.instructionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
        public PurchaseOrderPOItem[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        public byte TotalQnty
        {
            get
            {
                return this.totalQntyField;
            }
            set
            {
                this.totalQntyField = value;
            }
        }

        /// <remarks/>
        public decimal SubTotal
        {
            get
            {
                return this.subTotalField;
            }
            set
            {
                this.subTotalField = value;
            }
        }

        /// <remarks/>
        public byte Iva
        {
            get
            {
                return this.ivaField;
            }
            set
            {
                this.ivaField = value;
            }
        }

        /// <remarks/>
        public PurchaseOrderPOTotal Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public PurchaseOrderPOInvoiceTo InvoiceTo
        {
            get
            {
                return this.invoiceToField;
            }
            set
            {
                this.invoiceToField = value;
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PurchaseOrderPOVendor
    {

        private byte vendorIdField;

        private string vendorNameField;

        private string vendorAddressField;

        private string vendorCityField;

        private string vendorCountryField;

        private byte vendorZipCodeField;

        /// <remarks/>
        public byte VendorId
        {
            get
            {
                return this.vendorIdField;
            }
            set
            {
                this.vendorIdField = value;
            }
        }

        /// <remarks/>
        public string VendorName
        {
            get
            {
                return this.vendorNameField;
            }
            set
            {
                this.vendorNameField = value;
            }
        }

        /// <remarks/>
        public string VendorAddress
        {
            get
            {
                return this.vendorAddressField;
            }
            set
            {
                this.vendorAddressField = value;
            }
        }

        /// <remarks/>
        public string VendorCity
        {
            get
            {
                return this.vendorCityField;
            }
            set
            {
                this.vendorCityField = value;
            }
        }

        /// <remarks/>
        public string VendorCountry
        {
            get
            {
                return this.vendorCountryField;
            }
            set
            {
                this.vendorCountryField = value;
            }
        }

        /// <remarks/>
        public byte VendorZipCode
        {
            get
            {
                return this.vendorZipCodeField;
            }
            set
            {
                this.vendorZipCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PurchaseOrderPOShipTo
    {

        private byte shipToIdField;

        private string shipToNamePlaceField;

        private string shipToAddressField;

        private string shipToColonyField;

        private string shipToCityField;

        private string shipToStateField;

        private string shipToZipField;

        private object shipToTelephoneField;

        /// <remarks/>
        public byte ShipToId
        {
            get
            {
                return this.shipToIdField;
            }
            set
            {
                this.shipToIdField = value;
            }
        }

        /// <remarks/>
        public string ShipToNamePlace
        {
            get
            {
                return this.shipToNamePlaceField;
            }
            set
            {
                this.shipToNamePlaceField = value;
            }
        }

        /// <remarks/>
        public string ShipToAddress
        {
            get
            {
                return this.shipToAddressField;
            }
            set
            {
                this.shipToAddressField = value;
            }
        }

        /// <remarks/>
        public string ShipToColony
        {
            get
            {
                return this.shipToColonyField;
            }
            set
            {
                this.shipToColonyField = value;
            }
        }

        /// <remarks/>
        public string ShipToCity
        {
            get
            {
                return this.shipToCityField;
            }
            set
            {
                this.shipToCityField = value;
            }
        }

        /// <remarks/>
        public string ShipToState
        {
            get
            {
                return this.shipToStateField;
            }
            set
            {
                this.shipToStateField = value;
            }
        }

        /// <remarks/>
        public string ShipToZip
        {
            get
            {
                return this.shipToZipField;
            }
            set
            {
                this.shipToZipField = value;
            }
        }

        /// <remarks/>
        public object ShipToTelephone
        {
            get
            {
                return this.shipToTelephoneField;
            }
            set
            {
                this.shipToTelephoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PurchaseOrderPOInstruction
    {

        private string idField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PurchaseOrderPOItem
    {

        private string idField;

        private string quantityField;

        private string unitofMeasureField;

        private string modlField;

        private string upcField;

        private string descrField;

        private decimal unitCostField;

        private decimal weightField;

        private decimal cubeField;

        private object tabField;

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public string UnitofMeasure
        {
            get
            {
                return this.unitofMeasureField;
            }
            set
            {
                this.unitofMeasureField = value;
            }
        }

        /// <remarks/>
        public string modl
        {
            get
            {
                return this.modlField;
            }
            set
            {
                this.modlField = value;
            }
        }

        /// <remarks/>
        public string upc
        {
            get
            {
                return this.upcField;
            }
            set
            {
                this.upcField = value;
            }
        }

        /// <remarks/>
        public string Descr
        {
            get
            {
                return this.descrField;
            }
            set
            {
                this.descrField = value;
            }
        }

        /// <remarks/>
        public decimal UnitCost
        {
            get
            {
                return this.unitCostField;
            }
            set
            {
                this.unitCostField = value;
            }
        }

        /// <remarks/>
        public decimal Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        public decimal Cube
        {
            get
            {
                return this.cubeField;
            }
            set
            {
                this.cubeField = value;
            }
        }

        /// <remarks/>
        public object Tab
        {
            get
            {
                return this.tabField;
            }
            set
            {
                this.tabField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PurchaseOrderPOTotal
    {

        private string currencyField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PurchaseOrderPOInvoiceTo
    {

        private string invoiceNameField;

        private string invoiceAddress1Field;

        private string invoiceAddress2Field;

        private string invoiceAddress3Field;

        private string invoiceTelephoneField;

        private string invoiceFaxField;

        private string invoiceRfcField;

        /// <remarks/>
        public string InvoiceName
        {
            get
            {
                return this.invoiceNameField;
            }
            set
            {
                this.invoiceNameField = value;
            }
        }

        /// <remarks/>
        public string InvoiceAddress1
        {
            get
            {
                return this.invoiceAddress1Field;
            }
            set
            {
                this.invoiceAddress1Field = value;
            }
        }

        /// <remarks/>
        public string InvoiceAddress2
        {
            get
            {
                return this.invoiceAddress2Field;
            }
            set
            {
                this.invoiceAddress2Field = value;
            }
        }

        /// <remarks/>
        public string InvoiceAddress3
        {
            get
            {
                return this.invoiceAddress3Field;
            }
            set
            {
                this.invoiceAddress3Field = value;
            }
        }

        /// <remarks/>
        public string InvoiceTelephone
        {
            get
            {
                return this.invoiceTelephoneField;
            }
            set
            {
                this.invoiceTelephoneField = value;
            }
        }

        /// <remarks/>
        public string InvoiceFax
        {
            get
            {
                return this.invoiceFaxField;
            }
            set
            {
                this.invoiceFaxField = value;
            }
        }

        /// <remarks/>
        public string InvoiceRfc
        {
            get
            {
                return this.invoiceRfcField;
            }
            set
            {
                this.invoiceRfcField = value;
            }
        }
    }


}