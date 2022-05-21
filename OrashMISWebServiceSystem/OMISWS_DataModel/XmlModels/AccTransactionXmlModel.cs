using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OMISWS_DataModel.XmlModels
{
    public class AccTransactionXmlModel
    {
        //xml____________________


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
            public List<xmlAmodel> A { get; set; }
        }

        [XmlRoot]
        public class xmlAmodel
        {
            [XmlElement]
            public string HID { get; set; }

            [XmlElement]
            public string ANO { get; set; }

            [XmlElement]
            public string HDEC { get; set; }


            [XmlElement]
            public List<xmlADmodel> AD { get; set; }
        }

        [XmlRoot]
        public class xmlADmodel
        {
            [XmlElement]
            public string HID { get; set; }

            [XmlElement]
            public string IID { get; set; }

            [XmlElement]
            public string ROW { get; set; }

            [XmlElement]
            public string KL { get; set; }

            [XmlElement]
            public string MN { get; set; }

            [XmlElement]
            public string TC { get; set; }

            [XmlElement]
            public string IDE { get; set; }

            [XmlElement]
            public string D { get; set; }

            [XmlElement]
            public string C { get; set; }

            [XmlElement]
            public string T2 { get; set; }
        }
    }
}
