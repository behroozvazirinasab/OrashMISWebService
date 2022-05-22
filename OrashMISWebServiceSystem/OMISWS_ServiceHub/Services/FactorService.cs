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



        public List<ResponseModel> runFactorsp(List<FactorModel> Value, long Createuser, string Createdate, string Createtime, long? VisitorId, decimal? VisitorPrice)
        {
            var query = "sp_Insert_Factor_FromXml";
            var xml = getxml(Value);

            var queryparams = new
            {
                xmlVal = xml,
                CreateUser = Createuser,
                CreateDate = Createdate,
                CreateTime = Createtime,
                VisitorId = VisitorId,
                VisitorPrice = VisitorPrice,

            };
            var _res = dbContext.Connection.Query<ResponseModel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }



    }
}
