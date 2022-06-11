using Microsoft.AspNetCore.Mvc;
using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;
using OMISWS_ServiceHub.Services;


namespace OMISWS_ServiceApi.Controllers
{
    public class RecivePaymentController : ControllerBase
    {

        private readonly IRecivePaymentService _recivePaymentServices;

        public RecivePaymentController(IRecivePaymentService recivePaymentServices)
        {
            _recivePaymentServices = recivePaymentServices;
        }


        
        [HttpPost]
        [Route("api/OrashMISWebService/RecivePayment")]
        public async Task<Resmodel<IEnumerable<ResponseModel1>>> Post([FromBody] RecivePaymentInputModel recivePaymentInput)
        {

            var _res = await _recivePaymentServices.runRecivePaymentsp(recivePaymentInput);

            return _res;
        }
    }
}