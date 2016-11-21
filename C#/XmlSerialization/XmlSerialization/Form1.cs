using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XmlSerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Serialize_Click(object sender, EventArgs e)
        {   //#Note - Serialize by class
            //AddressDetails details = new AddressDetails();
            //details.HouseNo = 4;
            //details.StreetName = "Rohini";
            //details.City = "Delhi";
            //Serialize(details);

            //#Note - Serialize by list
            List<AddressDetails> AddressList = new List<AddressDetails>();
            AddressDetails detail1 = new AddressDetails();
            detail1.HouseNo = 4;
            detail1.StreetName = "ABC";
            detail1.City = "Delhi";

            AddressDetails detail2 = new AddressDetails();
            detail2.HouseNo = 3;
            detail2.StreetName = "ABCD";
            detail2.City = "New Delhi";

            AddressList.Add(detail1);
            AddressList.Add(detail2);
            Serialize((AddressList));
        }

        private void btn_SerializeAdvanced_Click(object sender, EventArgs e)
        {
            PersonalDetails details = new PersonalDetails();
            details.Name = "Mayank";
            details.Age = 24;

            //#Note - Add class object into another class.
            Address address = new Address { City = "Delhi", StreetName = "Rohini", HouseNo = 4 }; 
            details.address = address;

            SerializeAdvanced(details);
        }

        //static public void Serialize(AddressDetails details)
        static public void Serialize(List<AddressDetails> details)
        {
            //XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            XmlSerializer serializer = new XmlSerializer(typeof(List<AddressDetails>));

            using (TextWriter writer = new StreamWriter(@"C:\test\testSerialize.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }

        static public void SerializeAdvanced(PersonalDetails details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PersonalDetails));

            using (TextWriter writer = new StreamWriter(@"C:\test\testSerializeAdvance.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }

        private void btn_Deserialize_Click(object sender, EventArgs e)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(DeserializeAddress));
            TextReader reader = new StreamReader(@"C:\test\testDeserialize.xml");

            //#Note - Deserialize XML data in the XML file.
            object obj = deserializer.Deserialize(reader);
            DeserializeAddress XmlData = (DeserializeAddress)obj;
            reader.Close();
        }

        private void btn_DeserializeNested_Click(object sender, EventArgs e)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(AddressDirectory));
            TextReader reader = new StreamReader(@"C:\test\testDeserializeAdvance.xml");

            object obj = deserializer.Deserialize(reader);
            AddressDirectory XmlData = (AddressDirectory)obj;
            reader.Close();
        }
    }
}
