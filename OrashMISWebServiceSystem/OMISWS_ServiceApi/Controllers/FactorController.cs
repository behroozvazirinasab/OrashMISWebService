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
        public List<ResponseModel> Post([FromBody] FactorInputModel value)
        {
            
            var _res = _factorService.runFactorsp(value.Value, value.Createuser, value.Createdate, value.Createtime, value.VisitorId, value.VisitorPrice);
            return _res.ToList();
        }





    }
}
