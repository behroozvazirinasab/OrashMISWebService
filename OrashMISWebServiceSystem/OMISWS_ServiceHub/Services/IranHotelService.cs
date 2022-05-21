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




        public List<ResponseModel> runiranhotelsp(string Custcode, string Custname, string Custprice, string Custdesc, Int16 Turnovercode, string Date, List<IranHotelDataModel> supplier, List<IranHotelDataModel> bank)
        {
            var query = "sp_Insert_IRHotelData_FromXml";
            var supplierxml = getxml(supplier);
            var bankxml = getxml(bank);

            var queryparams = new
            {
                CustomerCode = Custcode,
                CustomerName = Custname,
                CustomerPrice = Custprice,
                CustomerDescription = Custdesc,
                TurnOverCode = Turnovercode,
                xmlSupplierList = supplierxml,
                xmlBankList = bankxml,
                CreateDate = Date
            };
            var _res = dbContext.Connection.Query<ResponseModel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }






    }
}
