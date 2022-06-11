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



        public async Task<ResponseModel1> runFactorsp(FactorInputModel input)
        {
            var query = "sp_Insert_Factor_FromXml";

            var xml = getxml(input.Value);

            var queryparams = new
            {
                xmlVal = xml,
                CreateUser = input.Createuser,
                CreateDate = input.Createdate,
                CreateTime = input.Createtime,
                VisitorId = input.VisitorId,
                VisitorPrice = input.VisitorPrice,

            };

            var _res = await dbContext.Connection.QuerySingleAsync<ResponseModel1>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res;
        }



    }
}
