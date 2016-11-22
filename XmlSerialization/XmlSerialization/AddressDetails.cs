
using System.Xml.Serialization;

namespace XmlSerialization
{
    //#Info - By default the name of the root element is same as the name of the classs that is serialized.
    [XmlRoot("Root")]
    public class AddressDetails
    {
        //#Info - By default, all Public fields and Public read/write properties are serialized by the XmlSerializer. 
        [XmlAttribute("Number")]
        public int HouseNo { get; set; }
        [XmlElement("Street")]
        public string StreetName { get; set; }
        public string City { get; set; }
        [XmlIgnore]
        private string PoAddress { get; set; }
    }
}
