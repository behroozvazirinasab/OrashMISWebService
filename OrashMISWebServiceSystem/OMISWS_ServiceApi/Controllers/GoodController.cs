using Microsoft.AspNetCore.Mvc;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.IServices;

namespace OMISWS_ServiceApi.Controllers
{
    public class GoodController : ControllerBase
    {
        private readonly IGoodService _goodService;

        public GoodController(IGoodService goodService)
        {
            _goodService = goodService;
        }



        [HttpPost]
        [Route("api/OrashMISWebService/InsertGood")]
        public List<ResponseModel2> Post([FromBody] GoodViewModel good)
        {

            var _res = _goodService.runInsertGoodsp(good);
            return _res.ToList();
        }


    }
}
