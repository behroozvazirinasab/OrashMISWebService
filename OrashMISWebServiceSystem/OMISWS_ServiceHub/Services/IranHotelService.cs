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
    public partial class IranHotelService : IIranHotelService
    {
        private readonly OMISWSDBContext dbContext;

        public IranHotelService(OMISWSDBContext _dbContext)
        {
            dbContext = _dbContext;
        }




        public async Task<Resmodel<IEnumerable<ResponseModel1>>> runiranhotelsp(IranHotelInputModel iranHotelInput)
        {
            var query = "sp_Insert_IRHotelData_FromXml";

            var supplierxml = getxml(iranHotelInput.supplier);
            var bankxml = getxml(iranHotelInput.bank);

            var queryparams = new
            {
                CustomerCode = iranHotelInput.CustomerCode,
                CustomerName = iranHotelInput.CustomerName,
                CustomerPrice = iranHotelInput.CustomerPrice,
                CustomerDescription = iranHotelInput.CustomerDescription,
                TurnOverCode = iranHotelInput.TurnOverCode,
                xmlSupplierList = supplierxml,
                xmlBankList = bankxml,
                CreateDate = iranHotelInput.CreateDate
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
