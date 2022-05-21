using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_DataModel.Models
{
    public class FactorInputModel
    {
        public long Createuser { get; set; }
        public string Createdate { get; set; }
        public string Createtime { get; set; }
        public long? VisitorId { get; set; }
        public decimal? VisitorPrice { get; set; }

        public List<FactorModel> Value { get; set; }
    }
    public class FactorModel
    {
        public string HID { get; set; }
        public string PC { get; set; }
        public string HDE { get; set; }
        public string FT { get; set; }
        public string MBL { get; set; }
        public string CN { get; set; }
        public string SF { get; set; }
        public string T2 { get; set; }
        public string SP { get; set; }
        public string DSC { get; set; }
        public string STP { get; set; }
        public string CC { get; set; }
        public string BOC { get; set; }
        public string CR { get; set; }
        public string UA { get; set; }
        public string HSC { get; set; }

        public List<FDmodel> FD { get; set; }

        public List<FBmodel> FB { get; set; }


    }
    public class FDmodel
    {
        public string HID { get; set; }
        public string IID { get; set; }
        public string GS { get; set; }
        public string GC { get; set; }
        public string FP { get; set; }
        public string IDE { get; set; }
        public string UPCR { get; set; }
        public string UPC { get; set; }
        public string OFR { get; set; }
        public string OP { get; set; }
        public string TAX { get; set; }
        public string PC { get; set; }
        public string TAS { get; set; }
        public string PER { get; set; }
        public string UPC1 { get; set; }
        public string UPC2 { get; set; }
        public string LV { get; set; }
        public string WV { get; set; }
        public string HV { get; set; }
        public string CV { get; set; }
        public string DV { get; set; }
        public string CFP { get; set; }
        public string CTP { get; set; }
        public string CRO { get; set; }
        public string CRT { get; set; }
        public string ITMS { get; set; }
    }

    public class FBmodel
    {
        public string HID { get; set; }
        public string BID { get; set; }
        public string DC { get; set; }
        public string WFEC { get; set; }
        public string WFLC { get; set; }
        public string FN { get; set; }
        public string WBB { get; set; }
        public string DG { get; set; }
        public string TFG { get; set; }
        public string POS { get; set; }
        public string POD { get; set; }
        public string DBL { get; set; }
        public string DP { get; set; }
    }

}
