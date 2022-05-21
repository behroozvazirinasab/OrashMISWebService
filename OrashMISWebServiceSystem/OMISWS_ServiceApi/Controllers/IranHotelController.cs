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
        public List<ResponseModel> Post([FromBody] IranHotelInputModel value)
        {
            
            var _res = _iranHotelServices.runiranhotelsp(value.custcode, value.custname, value.custprice, value.custdesc,
                                         value.turnovercode, value.date, value.supplier, value.bank);
            return _res.ToList();
        }
    }
}
