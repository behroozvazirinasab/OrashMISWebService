using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_ServiceHub.IServices
{
    public interface IStockGoodInStorgeService
    {
        Task<Resmodel<IEnumerable<StockGoodInStorgeResponseModel>>> runStockGoodInStorgesp(StockGoodInStorgeViewModel StockGood);



        StockGoodInStorgeModel MapForInsert(StockGoodInStorgeViewModel StockGood);
    }
}
