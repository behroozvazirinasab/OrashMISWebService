using Microsoft.AspNetCore.Mvc;
using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;
using OMISWS_ServiceHub.Services;

namespace OMISWS_ServiceApi.Controllers
{
    public class FactorController : ControllerBase
    {
        private readonly IFactorService _factorService;

        public FactorController(IFactorService factorService)
        {
            _factorService = factorService;
        }




        [HttpPost]
        [Route("api/OrashMISWebService/Factor")]
        public async Task<ResponseModel1> Post([FromBody] FactorInputModel input)
        {
            
            var _res = await _factorService.runFactorsp(input);
            return _res;
        }



    }
}
