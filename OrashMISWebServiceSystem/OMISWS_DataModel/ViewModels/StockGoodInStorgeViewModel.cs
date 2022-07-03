using OMISWS_DataModel.BaseModels;
using OMISWS_DataModel.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_DataModel.ViewModels
{
    public class StockGoodInStorgeViewModel : IStockGoodInStorgeBaseModel
    {
        public string? GoodsCode { get; set; }
        public long? StorageCode { get; set; }

        public long ItmID { get; set; } = 0;

        public string Date { get; set; } = DateTime.Now.ToPeString("yyyyMMdd");

        public bool ByNow { get; set; } = true;

        public bool CashMenuMode { get; set; } = false;
    }
}
