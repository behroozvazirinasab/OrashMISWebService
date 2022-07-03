using Dapper;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.Contexts;
using OMISWS_ServiceHub.IServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_ServiceHub.Services
{
    
        public partial class StockGoodInStorgeService : IStockGoodInStorgeService
        {
            private readonly OMISWSDBContext dbContext;

            public StockGoodInStorgeService(OMISWSDBContext _dbContext)
            {
                dbContext = _dbContext;
            }


        public async Task<Resmodel<IEnumerable<StockGoodInStorgeResponseModel>>> runStockGoodInStorgesp(StockGoodInStorgeViewModel StockGood)
        {
            var query = "SP_StockGoodInStorge";

            var model = MapForInsert(StockGood);

            var queryparams = new
            {
                GoodsCode = StockGood.GoodsCode,
                StorageCode = StockGood.StorageCode,
                ItmID = StockGood.ItmID,
                Date = StockGood.Date,
                ByNow = StockGood.ByNow,
                CashMenuMode = StockGood.CashMenuMode
            };


            try
            {
                var _res = await dbContext.Connection.QueryAsync<StockGoodInStorgeResponseModel>(query, queryparams, commandType: CommandType.StoredProcedure);

                return new Resmodel<IEnumerable<StockGoodInStorgeResponseModel>>()
                {
                    Result = _res
                };
            }
            catch (Exception) { throw; }
        }
    }
}
