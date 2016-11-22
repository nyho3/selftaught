using System.Xml.Serialization;

namespace XmlSerialization
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Address address;
    }
    public class Address
    {
        [XmlAttribute("HouseNo")]
        public int HouseNo { get; set; }
        [XmlText]
        public string StreetName { get; set; }
        [XmlIgnore]
        public string City { get; set; }
    }
}
