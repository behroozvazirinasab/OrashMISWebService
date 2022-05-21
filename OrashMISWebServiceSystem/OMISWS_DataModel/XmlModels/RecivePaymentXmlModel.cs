using System.Xml.Serialization;

namespace OMISWS_DataModel.XmlModels
{
    public class RecivePaymentXmlModel
    {
        //xml__________________________


        [XmlRoot]
        public class rootmodel
        {
            [XmlElement]
            public RootObject root { get; set; }
        }

        [XmlRoot]
        public class RootObject
        {
            [XmlElement]
            public List<xmlRmodel> R { get; set; }
        }

        [XmlRoot]
        public class xmlRmodel
        {
            [XmlElement]
            public string HID { get; set; }

            [XmlElement]
            public string PC { get; set; }

            [XmlElement]
            public string RPT { get; set; }

            [XmlElement]
            public string RPC { get; set; }

            [XmlElement]
            public string T2 { get; set; }

            [XmlElement]
            public string ET { get; set; }



            [XmlElement]
            public List<xmlRDmodel> RD { get; set; }
        }

        [XmlRoot]
        public class xmlRDmodel
        {

            [XmlElement]
            public string HID { get; set; }

            [XmlElement]
            public string IID { get; set; }

            [XmlElement]
            public string PRC { get; set; }

            [XmlElement]
            public string IDISC { get; set; }

            [XmlElement]
            public string P { get; set; }

            [XmlElement]
            public string TAX { get; set; }

            [XmlElement]
            public string T2 { get; set; }

            [XmlElement]
            public string PRC1 { get; set; }

            [XmlElement]
            public string T21 { get; set; }

        }
    }
}
