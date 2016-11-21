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
    }

    public class Directory
    {
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
    }
}
