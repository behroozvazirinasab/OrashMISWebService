
using OMISWS_DataModel.Models;

namespace OMISWS_DataModel.BaseModels
{
    public interface IRecivePaymentInputModel
    {
        public long Createuser { get; set; }
        public string Createdate { get; set; }
        public string Createtime { get; set; }


        public List<RecivePaymentDataModel> Value { get; set; }
    }

    public interface IRecivePaymentDataModel
    {
        public string HID { get; set; }
        public string PC { get; set; }
        public string RPT { get; set; }
        public string RPC { get; set; }
        public string T2 { get; set; }
        public string ET { get; set; }


        public List<RDmodel> RD { get; set; }

    }

    public interface IRDmodel
    {
        public string HID { get; set; }
        public string IID { get; set; }
        public string PRC { get; set; }
        public string IDISC { get; set; }
        public string P { get; set; }
        public string TAX { get; set; }
        public string T2 { get; set; }
        public string PRC1 { get; set; }
        public string T21 { get; set; }

    }


}
