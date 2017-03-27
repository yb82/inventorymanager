using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IHBrisbane_ALS_Inventory_Manager.Config
{
    public class Configuration
    {
        private XElement xmlFile;
        static public string ipaddress;
        static public string id;
        static public string password;

        public XElement XmlFile
        {
            get { return xmlFile; }
            set { xmlFile = value; }
        }
        public Configuration()
        {
            try
            {
                if(ipaddress == null || ipaddress =="")
                this.ReadData();
            }
            catch (Exception e)
            {
                //throw (e.Message);
            }
            //xmlFile.Save("courseproperty.xml");
            
        }
        private void ReadData()
        {
            try
            {
                xmlFile = XElement.Load("config.xml");


            }
            catch (Exception e)
            {

            }
            var query = from c in xmlFile.Elements()
                        select c;

            foreach (XElement el in query)
            {
                //Console.WriteLine(el.Name);

                //Console.WriteLine( el.Attribute("name"));
                if (el.Name == "Server")
                {
                    ipaddress = el.Attribute("ip").Value;
                    id = el.Attribute("id").Value;
                    password = el.Attribute("password").Value;
                }
                

            }
        }
    }
}
