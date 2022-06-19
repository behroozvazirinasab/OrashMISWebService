using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.IServices;

namespace OMISWS_ServiceApi.Controllers
{
    //[ApiController]
    public class ChangeGoodRateController : ControllerBase
    {
        private readonly IChangeGoodRateService _changeGoodRateService;

        public ChangeGoodRateController(IChangeGoodRateService changeGoodRateService)
        {
            _changeGoodRateService = changeGoodRateService;
        }







        [HttpPost] 
        [Route("api/OrashMISWebService/ChangeGoodRate")]
        public async Task<Resmodel<IEnumerable<ResponseModel4>>> Post([FromBody] ChangeGoodRateViewModel rateInput)
        {
            
                var _res = await _changeGoodRateService.runChangeGoodRatesp(rateInput);

                return _res;
           

        }

    }
}
