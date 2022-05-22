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
        public List<ResponseModel1> Post([FromBody] RecivePaymentInputModel value)
        {

            var _res = _recivePaymentServices.runRecivePaymentsp(value.Value, value.Createuser, value.Createdate, value.Createtime);

            return _res.ToList();
        }
    }
}