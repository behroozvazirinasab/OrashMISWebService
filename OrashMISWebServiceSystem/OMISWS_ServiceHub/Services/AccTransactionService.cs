using Dapper;
using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;
using OMISWS_ServiceHub.Contexts;
using OMISWS_ServiceHub.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_ServiceHub.Services
{
    public partial class AccTransactionService : IAccTransactionService
    {
        private readonly OMISWSDBContext dbContext;

        public AccTransactionService(OMISWSDBContext _dbContext)
        {
            dbContext = _dbContext;
        }



        public async Task<Resmodel<IEnumerable<ResponseModel3>>> runAccTransactionsp(AccTransactionInputModel accInput)
        {
            var query = "sp_Insert_AccTransaction_FromXml";

            var xml = getxml(accInput.Value);

            var queryparams = new
            {
                xmlVal = xml,
                CreateUser = accInput.Createuser,
                CreateDate = accInput.Createdate,
                CreateTime = accInput.Createtime
            };


            try 
            { 
                var _res = await dbContext.Connection.QueryAsync<ResponseModel3>(query, queryparams, commandType: CommandType.StoredProcedure);

                return new Resmodel<IEnumerable<ResponseModel3>>()
                {
                    Result = _res
                };
            }
            catch (Exception) { throw; }
        }

    }
}
