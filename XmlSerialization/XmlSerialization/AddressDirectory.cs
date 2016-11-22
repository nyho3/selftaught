using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization
{
    public class AddressDirectory
    {
        [XmlElement("Directory")]
        public List<Directory> addressList = new List<Directory>();

        public string Owner { get; set; }
        public string Age { get; set; }
        public string Company { get; set; }

        [XmlElement("DirectoryOwner")]
        public string DirectoryOwner { get; set; }

        [XmlElement("PinCode")] //#ToDo - Find out why cannot use [XmlText] to store inner text.
        public string PinCode { get; set; }
        [XmlElement("Address")]
        public List<Address> Address { get; set; }

        [XmlElement("Designation")]
        public Designation designation { get; set; }

        [XmlAttribute("id")]
        public string ID { get; set; }
    }

    public class Directory
    {
        [XmlAttribute("AddressId")]
        public string AddressId { get; set; }
        [XmlElement("HouseNo")]
        public string HouseNo { get; set; }
        [XmlElement("StreetName")]
        public string StreetName { get; set; }
        [XmlElement("City")]
        public string City { get; set; }
    }

    public class Designation
    {
        [XmlAttribute("place")]
        public string place { get; set; }
        [XmlText]
        public string JobType { get; set; }
    }
}
