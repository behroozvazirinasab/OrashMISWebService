using Microsoft.AspNetCore.Mvc;
using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;
using OMISWS_ServiceHub.Services;

namespace OMISWS_ServiceApi.Controllers
{
    public class AccTransactionController : ControllerBase
    {
        private readonly IAccTransactionService _accTransactionServices;

        public AccTransactionController(IAccTransactionService accTransactionServices)
        {
            _accTransactionServices = accTransactionServices;
        }






        [HttpPost]
        [Route("api/OrashMISWebService/AccTransaction")]
        public List<ResponseModel> Post([FromBody] AccTransactionInputModel value)
        {

            var _res = _accTransactionServices.runAccTransactionsp(value.Value, value.Createuser, value.Createdate, value.Createtime);

            return _res.ToList();
        }







    }
}
