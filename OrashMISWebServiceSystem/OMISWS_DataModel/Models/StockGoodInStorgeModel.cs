using OMISWS_DataModel.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_DataModel.Models
{
    public class StockGoodInStorgeModel
    {
        public string? GoodsCode { get; set; }
        public long? StorageCode { get; set; }

        public long ItmID = 0;

        public string Date = DateTime.Now.ToPeString("yyyyMMdd");

        public bool ByNow = true;

        public bool CashMenuMode = false;
    }
}
