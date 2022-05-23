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
        public List<ResponseModel2> Post([FromBody] GoodInsertViewModel good)
        {

            var _res = _goodService.runInsertGoodsp(good);
            return _res.ToList();
        }





        [HttpPost]
        [Route("api/OrashMISWebService/SearchGood")]
        public List<GoodSearchResponseModel> Post([FromBody] GoodSearchViewModel good)
        {

            var _res = _goodService.runSearchGoodsp(good);
            return _res.ToList();
        }
    }
}
