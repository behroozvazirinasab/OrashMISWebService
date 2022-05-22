using Dapper;
using System.Data;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.Models;
using OMISWS_ServiceHub.Contexts;

namespace OMISWS_ServiceHub.Services
{
    public partial class RecivePaymentService : IRecivePaymentService
    {



        private readonly OMISWSDBContext dbContext;

        public RecivePaymentService(OMISWSDBContext _dbContext)
        {
            dbContext = _dbContext;
        }
        


        public List<ResponseModel1> runRecivePaymentsp(List<RecivePaymentDataModel> Value, long Createuser, string Createdate, string Createtime)
        {
            var query = "sp_Insert_RecivePayment_FromXml";
            var xml = getxml(Value);

            var queryparams = new
            {
                xmlVal = xml,
                Createuser = Createuser,
                Createdate = Createdate,
                Createtime = Createtime

            };

            var _res = dbContext.Connection.Query<ResponseModel1>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }
    }

}
