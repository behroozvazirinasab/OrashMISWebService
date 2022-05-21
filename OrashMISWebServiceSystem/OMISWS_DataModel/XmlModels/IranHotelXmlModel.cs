using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OMISWS_DataModel.XmlModels
{
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
        public List<xmlModel> H { get; set; }
    }

    [XmlRoot]
    public class xmlModel
    {
        [XmlElement]
        public string Code { get; set; }

        [XmlElement]
        public string Name { get; set; }

        [XmlElement]
        public double Price { get; set; }

        [XmlElement]
        public string DE { get; set; }

        [XmlElement]
        public int Type { get; set; }
    }
}
