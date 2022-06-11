using Dapper;
using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;
using OMISWS_ServiceHub.Contexts;
using System.Data;

namespace OMISWS_ServiceHub.Services
{
    public partial class FactorService : IFactorService
    {
        private readonly OMISWSDBContext dbContext;

        public FactorService(OMISWSDBContext _dbContext)
        {
            dbContext = _dbContext;
        }



        public async Task<Resmodel<IEnumerable<ResponseModel1>>> runFactorsp(FactorInputModel factorInput)
        {
            var query = "sp_Insert_Factor_FromXml";

            var xml = getxml(factorInput.Value);

            var queryparams = new
            {
                xmlVal = xml,
                CreateUser = factorInput.Createuser,
                CreateDate = factorInput.Createdate,
                CreateTime = factorInput.Createtime,
                VisitorId = factorInput.VisitorId,
                VisitorPrice = factorInput.VisitorPrice,

            };

            try
            {
                var _res = await dbContext.Connection.QueryAsync<ResponseModel1>(query, queryparams, commandType: CommandType.StoredProcedure);

                return new Resmodel<IEnumerable<ResponseModel1>>()
                {
                    Result = _res
                };
            }
            catch (Exception) { throw; }
        }



    }
}
