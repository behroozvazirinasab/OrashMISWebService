using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OMISWS_DataModel.XmlModels
{
    public class FactorXmlModel
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
            public List<xmlFModel> F { get; set; }
        }

        [XmlRoot]
        public class xmlFModel
        {
            [XmlElement]
            public string HID { get; set; }
            [XmlElement]
            public string PC { get; set; }
            [XmlElement]
            public string HDE { get; set; }
            [XmlElement]
            public string FT { get; set; }
            [XmlElement]
            public string MBL { get; set; }
            [XmlElement]
            public string CN { get; set; }
            [XmlElement]
            public string SF { get; set; }
            [XmlElement]
            public string T2 { get; set; }
            [XmlElement]
            public string SP { get; set; }
            [XmlElement]
            public string DSC { get; set; }
            [XmlElement]
            public string STP { get; set; }
            [XmlElement]
            public string CC { get; set; }
            [XmlElement]
            public string BOC { get; set; }
            [XmlElement]
            public string CR { get; set; }
            [XmlElement]
            public string UA { get; set; }
            [XmlElement]
            public string HSC { get; set; }



            [XmlElement]
            public List<xmlFDmodel> FD { get; set; }

            [XmlElement]
            public List<xmlFBmodel> FB { get; set; }
        }

        [XmlRoot]
        public class xmlFDmodel
        {
            [XmlElement]
            public string HID { get; set; }
            [XmlElement]
            public string IID { get; set; }
            [XmlElement]
            public string GS { get; set; }
            [XmlElement]
            public string GC { get; set; }
            [XmlElement]
            public string FP { get; set; }
            [XmlElement]
            public string IDE { get; set; }
            [XmlElement]
            public string UPCR { get; set; }
            [XmlElement]
            public string UPC { get; set; }
            [XmlElement]
            public string OFR { get; set; }
            [XmlElement]
            public string OP { get; set; }
            [XmlElement]
            public string TAX { get; set; }
            [XmlElement]
            public string PC { get; set; }
            [XmlElement]
            public string TAS { get; set; }
            [XmlElement]
            public string PER { get; set; }
            [XmlElement]
            public string UPC1 { get; set; }
            [XmlElement]
            public string UPC2 { get; set; }
            [XmlElement]
            public string LV { get; set; }
            [XmlElement]
            public string WV { get; set; }
            [XmlElement]
            public string HV { get; set; }
            [XmlElement]
            public string CV { get; set; }
            [XmlElement]
            public string DV { get; set; }
            [XmlElement]
            public string CFP { get; set; }
            [XmlElement]
            public string CTP { get; set; }
            [XmlElement]
            public string CRO { get; set; }
            [XmlElement]
            public string CRT { get; set; }
            [XmlElement]
            public string ITMS { get; set; }
        }

        public class xmlFBmodel
        {
            [XmlElement]
            public string HID { get; set; }
            [XmlElement]
            public string BID { get; set; }
            [XmlElement]
            public string DC { get; set; }
            [XmlElement]
            public string WFEC { get; set; }
            [XmlElement]
            public string WFLC { get; set; }
            [XmlElement]
            public string FN { get; set; }
            [XmlElement]
            public string WBB { get; set; }
            [XmlElement]
            public string DG { get; set; }
            [XmlElement]
            public string TFG { get; set; }
            [XmlElement]
            public string POS { get; set; }
            [XmlElement]
            public string POD { get; set; }
            [XmlElement]
            public string DBL { get; set; }
            [XmlElement]
            public string DP { get; set; }

        }
    }
}
