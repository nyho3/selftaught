using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerialization
{
    //#Note - Class variable/property should always be declared as Public
    public class DeserializeAddress
    {
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }    
    }
}
