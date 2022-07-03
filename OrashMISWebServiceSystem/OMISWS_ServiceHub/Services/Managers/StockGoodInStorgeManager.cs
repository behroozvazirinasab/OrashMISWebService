using OMISWS_DataModel.Models;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_ServiceHub.Services
{
    public partial class StockGoodInStorgeService : IStockGoodInStorgeService
    {
        public StockGoodInStorgeModel MapForInsert(StockGoodInStorgeViewModel StockGood)
        {
            return new StockGoodInStorgeModel()
            {
                GoodsCode = StockGood.GoodsCode,
                StorageCode = StockGood.StorageCode,
                ItmID = StockGood.ItmID,
                Date = StockGood.Date,
                ByNow = StockGood.ByNow,
                CashMenuMode = StockGood.CashMenuMode
            };


        }
    }
}
