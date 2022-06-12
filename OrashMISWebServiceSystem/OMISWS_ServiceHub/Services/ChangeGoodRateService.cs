using Dapper;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.Contexts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_ServiceHub.Services
{
    public partial class ChangeGoodRateService
    {
        private readonly OMISWSDBContext dbContext;

        public ChangeGoodRateService(OMISWSDBContext _dbContext)
        {
            dbContext = _dbContext;
        }


        public async Task<Resmodel<IEnumerable<ResponseModel4>>> runChangeGoodRatesp(ChangeGoodRateViewModel rateInput)
        {
            var query = "SP_ChangeGoodRate";

            var model = MapForInsert(rateInput);

            var queryparams = new
            {
                GoodCode = model.GoodCode,
                StorageCode = model.StorageCode,
                FiPrice1 = model.FiPrice1,
                OffPercent1 = model.OffPercent1,
                FiPrice2 = model.FiPrice2,
                OffPercent2 = model.OffPercent2,
                FiPrice3 = model.FiPrice3,
                OffPercent3 = model.OffPercent3,
                UserIdRef = model.UserIdRef
            };


            try
            {
                var _res = await dbContext.Connection.QueryAsync<ResponseModel4>(query, queryparams, commandType: CommandType.StoredProcedure);

                return new Resmodel<IEnumerable<ResponseModel4>>()
                {
                    Result = _res
                };
            }
            catch (Exception) { throw; }
        }
    }
}
