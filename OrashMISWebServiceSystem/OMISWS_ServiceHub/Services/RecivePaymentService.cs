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
        


        public async Task<Resmodel<IEnumerable<ResponseModel1>>> runRecivePaymentsp(RecivePaymentInputModel recivePaymentInput/*List<RecivePaymentDataModel> Value, long Createuser, string Createdate, string Createtime*/)
        {
            var query = "sp_Insert_RecivePayment_FromXml";
            var xml = getxml(recivePaymentInput.Value);

            var queryparams = new
            {
                xmlVal = xml,
                Createuser = recivePaymentInput.Createuser,
                Createdate = recivePaymentInput.Createdate,
                Createtime = recivePaymentInput.Createtime

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
