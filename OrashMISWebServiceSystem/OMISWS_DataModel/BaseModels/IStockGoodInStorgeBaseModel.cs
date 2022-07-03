using OMISWS_DataModel.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_DataModel.BaseModels
{
    public interface IStockGoodInStorgeBaseModel 
    {
        public string? GoodsCode { get; set; }
        public long? StorageCode { get; set; }

        public long ItmID { get; set; }

        public string Date { get; set; } 

        public bool ByNow { get; set; } 

        public bool CashMenuMode { get; set; } 
    }
}
