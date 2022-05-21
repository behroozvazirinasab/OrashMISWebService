using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_DataModel.Models
{
    public class AccTransactionInputModel
    {
        public long Createuser { get; set; }
        public string Createdate { get; set; }
        public string Createtime { get; set; }

        public List<FactorDataModel> Value { get; set; }
    }
    public class FactorDataModel
    {
        public string HID { get; set; }
        public string ANO { get; set; }
        public string HDEC { get; set; }


        public List<ADmodel> AD { get; set; }

    }
    public class ADmodel
    {
        public string HID { get; set; }
        public string IID { get; set; }
        public string ROW { get; set; }
        public string KL { get; set; }
        public string MN { get; set; }
        public string TC { get; set; }
        public string IDE { get; set; }
        public string D { get; set; }
        public string C { get; set; }
        public string T2 { get; set; }
    }
}
