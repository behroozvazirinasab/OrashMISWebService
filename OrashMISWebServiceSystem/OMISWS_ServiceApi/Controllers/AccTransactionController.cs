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
        public async Task<Resmodel<IEnumerable<ResponseModel3>>> Post([FromBody] AccTransactionInputModel accInput)
        {

            var _res = await _accTransactionServices.runAccTransactionsp(accInput);

            return _res;
        }



    }
}
