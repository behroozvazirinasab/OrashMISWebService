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
        public async Task<Resmodel<IEnumerable<ResponseModel1>>> Post([FromBody] FactorInputModel factorInput)
        {
            
            var _res = await _factorService.runFactorsp(factorInput);
            return _res;
        }



    }
}
