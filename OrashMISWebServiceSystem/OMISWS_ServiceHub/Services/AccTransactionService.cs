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



        public List<ResponseModel1> runAccTransactionsp(List<FactorDataModel> Value, long Createuser, string Createdate, string Createtime)
        {
            var query = "sp_Insert_AccTransaction_FromXml";
            var xml = getxml(Value);

            var queryparams = new
            {
                xmlVal = xml,
                CreateUser = Createuser,
                CreateDate = Createdate,
                CreateTime = Createtime

            };
            var _res = dbContext.Connection.Query<ResponseModel1>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }

    }
}
