namespace OMISWS_DataModel.Models
{

    public class RecivePaymentInputModel 
    {
        public long Createuser { get; set; }
        public string Createdate { get; set; }
        public string Createtime { get; set; }


        public List<RecivePaymentDataModel> Value { get; set; }
    }

    public class RecivePaymentDataModel 
    {
        public string HID { get; set; }
        public string PC { get; set; }
        public string RPT { get; set; }
        public string RPC { get; set; }
        public string T2 { get; set; }
        public string ET { get; set; }


        public List<RDmodel> RD { get; set; }

    }

    public class RDmodel 
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

