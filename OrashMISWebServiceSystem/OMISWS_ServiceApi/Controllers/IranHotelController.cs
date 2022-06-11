using Microsoft.AspNetCore.Mvc;
using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;
using OMISWS_ServiceHub.Services;

namespace OMISWS_ServiceApi.Controllers
{
    public class IranHotelController : ControllerBase
    {

        private readonly IIranHotelService _iranHotelServices;

        public IranHotelController(IIranHotelService iranHotelServices)
        {
            _iranHotelServices = iranHotelServices;
        }



        [HttpPost]
        [Route("api/OrashMISWebService/IranHotel")]
        public async Task<Resmodel<IEnumerable<ResponseModel1>>> Post([FromBody] IranHotelInputModel iranHotelInput)
        {
            
            var _res = await _iranHotelServices.runiranhotelsp(iranHotelInput);

            return _res;
        }
    }
}
