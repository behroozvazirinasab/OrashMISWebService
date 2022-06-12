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
        public async Task<Resmodel<IEnumerable<ResponseModel2>>> Post([FromBody] GoodInsertViewModel goodInsert)
        {

            var _res = await _goodService.runInsertGoodsp(goodInsert/*goodInsert.Code , goodInsert.Name, goodInsert.Type, goodInsert.UnitIdRef, goodInsert.MainGroupCodeRef, goodInsert.SecondGroupCodeRef, goodInsert.Pic,
                                                            goodInsert.IsAdded, goodInsert.ImageData, goodInsert.IsBuyAdded, goodInsert.Serial, goodInsert.FiPrice1, goodInsert.OffPercent1, goodInsert.FiPrice2, 
                                                            goodInsert.OffPercent2, goodInsert.FiPrice3, goodInsert.OffPercent3, goodInsert.SaleName, goodInsert.UnitPackingCodeRef, goodInsert.TaxPercent, goodInsert.lengthValue, 
                                                            goodInsert.WidthValue, goodInsert.HeightValue, goodInsert.GoodCategoryIdRef, goodInsert.IsActive, goodInsert.DiameterValue, goodInsert.SerialsControl, goodInsert.PatternIdRef, goodInsert.NationalCode,
                                                            goodInsert.WeightPack, goodInsert.WeightGoods, goodInsert.CriterionWeight, goodInsert.DimensionsLengthPack, goodInsert.DimensionsWidthPack, goodInsert.DimensionsHeightPack, goodInsert.DimensionsLengthGoods,
                                                            goodInsert.DimensionsWidthGoods, goodInsert.DimensionsHeightGoods, goodInsert.CriterionDimensions*/);
            return _res;
        }





        //[HttpPost]
        //[Route("api/OrashMISWebService/SearchGood")]
        //public List<GoodSearchResponseModel> Post([FromBody] GoodSearchViewModel good)
        //{

        //    var _res = _goodService.runSearchGoodsp(good);
        //    return _res.ToList();
        //}
    }
}
