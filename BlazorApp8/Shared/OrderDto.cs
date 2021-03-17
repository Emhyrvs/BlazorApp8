using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BlazorApp8.Shared
{
    [XmlRoot("OrderDto")]
    public class OrderDto
    {



        [XmlElement("AddressDelivery")]
        public string AddressDelivery { get; set; }
        [XmlElement("OrderId")]
        public string OrderId { get; set; }
        [XmlElement("CommodityCode")]
        public int CommodityCode { get; set; }
        [XmlElement("ProductName")]
        public string ProductName { get; set; }
        [XmlElement("Volume")]
        public string Volume { get; set; }
        [XmlElement("FullNameDriver")]
        public string FullNameDriver { get; set; }
        [XmlElement("PhoneDriver")]
        public string PhoneDriver { get; set; }
        [XmlElement("EmailDriver")]
        public string EmailDriver { get; set; }
        [XmlElement("FullNameCustomer")]
        public string FullNameCustomer { get; set; }
        [XmlElement("AddressCustomer")]
        public string AddressCustomer { get; set; }
        [XmlElement("PhoneCustomer")]
        public string PhoneCustomer { get; set; }
        [XmlElement("EmailCustomer")]
        public string EmailCustomer { get; set; }
        [XmlElement("SentNo")]
        public string SentNo { get; set; }
        [XmlElement("SentRecipentKey")]
        public string SentRecipentKey { get; set; }
        [XmlElement("SentCarrierKey")]
        public string SentCarrierKey { get; set; }
        [XmlElement("SellerVehicle")]
        public string SellerVehicle { get; set; }
        [XmlElement("PaymentDate")]
        public string PaymentDate { get; set; }
        [XmlElement("FullNamePayer")]
        public string FullNamePayer { get; set; }
        [XmlElement("AddressPayer")]
        public string AddressPayer { get; set; }




    }
}
