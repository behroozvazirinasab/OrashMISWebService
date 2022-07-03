using Microsoft.AspNetCore.Mvc;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.IServices;

namespace OMISWS_ServiceApi.Controllers
{
    public class StockGoodInStorgeController : ControllerBase
    {
        private readonly IStockGoodInStorgeService _stockGoodInStorgeService;

        public StockGoodInStorgeController(IStockGoodInStorgeService stockGoodInStorgeService)
        {
            _stockGoodInStorgeService = stockGoodInStorgeService;
        }



        [HttpPost]
        [Route("api/OrashMISWebService/StockGoodInStorge")]
        public async Task<Resmodel<IEnumerable<StockGoodInStorgeResponseModel>>> Post([FromBody] StockGoodInStorgeViewModel StockGood)
        {

            var _res = await _stockGoodInStorgeService.runStockGoodInStorgesp(StockGood);

            return _res;
        }
    }
}
