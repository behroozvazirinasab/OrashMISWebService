using Dapper;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.Contexts;
using OMISWS_ServiceHub.IServices;
using System.Data;

namespace OMISWS_ServiceHub.Services
{
    public class GoodService : IGoodService
    {
        private readonly OMISWSDBContext dbContext;

        public GoodService(OMISWSDBContext _dbContext)
        {
            dbContext = _dbContext;
        }



        public List<ResponseModel2> runInsertGoodsp(GoodInsertViewModel goodInsertViewModel)
        {
            var query = "InsertGoods";

            var queryparams = new
            {
                Code = goodInsertViewModel.Code,
                Name = goodInsertViewModel.Name,
                Type = goodInsertViewModel.Type,
                UnitIdRef = goodInsertViewModel.UnitIdRef,
                MainGroupCodeRef = goodInsertViewModel.MainGroupCodeRef,
                SecondGroupCodeRef = goodInsertViewModel.SecondGroupCodeRef,
                Pic = goodInsertViewModel.Pic,
                IsAdded = goodInsertViewModel.IsAdded,
                ImageData = goodInsertViewModel.ImageData,
                IsBuyAdded = goodInsertViewModel.IsBuyAdded,
                Serial = goodInsertViewModel.Serial,
                FiPrice1 = goodInsertViewModel.FiPrice1,
                OffPercent1 = goodInsertViewModel.OffPercent1,
                FiPrice2 = goodInsertViewModel.FiPrice2,
                OffPercent2 = goodInsertViewModel.OffPercent2,
                FiPrice3 = goodInsertViewModel.FiPrice3,
                OffPercent3 = goodInsertViewModel.OffPercent3,
                SaleName = goodInsertViewModel.SaleName,
                UnitPackingCodeRef = goodInsertViewModel.UnitPackingCodeRef,
                TaxPercent = goodInsertViewModel.TaxPercent,
                lengthValue = goodInsertViewModel.lengthValue,
                WidthValue = goodInsertViewModel.WidthValue,
                HeightValue = goodInsertViewModel.HeightValue,
                GoodCategoryIdRef = goodInsertViewModel.GoodCategoryIdRef,
                IsActive = goodInsertViewModel.IsActive,
                DiameterValue = goodInsertViewModel.DiameterValue,
                SerialsControl = goodInsertViewModel.SerialsControl,
                PatternIdRef = goodInsertViewModel.PatternIdRef,
                NationalCode = goodInsertViewModel.NationalCode,
                WeightPack = goodInsertViewModel.WeightPack,
                WeightGoods = goodInsertViewModel.WeightGoods,
                CriterionWeight = goodInsertViewModel.CriterionWeight,
                DimensionsLengthPack = goodInsertViewModel.DimensionsLengthPack,
                DimensionsWidthPack = goodInsertViewModel.DimensionsWidthPack,
                DimensionsHeightPack = goodInsertViewModel.DimensionsHeightPack,
                DimensionsLengthGoods = goodInsertViewModel.DimensionsLengthGoods,
                DimensionsWidthGoods = goodInsertViewModel.DimensionsWidthGoods,
                DimensionsHeightGoods = goodInsertViewModel.DimensionsHeightGoods,
                CriterionDimensions = goodInsertViewModel.CriterionDimensions

            };

            var _res = dbContext.Connection.Query<ResponseModel2>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }




        public List<GoodSearchResponseModel> runSearchGoodsp(GoodSearchViewModel goodSearchViewModel)
        {
            var query = "SearchGoods";

            var queryparams = new
            {
                Code = goodSearchViewModel.Code,
                Name = goodSearchViewModel.Name,
                Type = goodSearchViewModel.Type,
                UnitsName = goodSearchViewModel.UnitsName,
                MainGroupName = goodSearchViewModel.MainGroupName,
                SecondGroupName = goodSearchViewModel.SecondGroupName,
                Serial = goodSearchViewModel.Serial,
                FiPrice1 = goodSearchViewModel.FiPrice1,
                OffPercent1 = goodSearchViewModel.OffPercent1,
                FiPrice2 = goodSearchViewModel.FiPrice2,
                OffPercent2 = goodSearchViewModel.OffPercent2,
                FiPrice3 = goodSearchViewModel.FiPrice3,
                OffPercent3 = goodSearchViewModel.OffPercent3,
                SaleName = goodSearchViewModel.SaleName,
                UnitPackingName = goodSearchViewModel.UnitPackingName,
                TaxPercent = goodSearchViewModel.TaxPercent,
                lengthValue = goodSearchViewModel.lengthValue,
                WidthValue = goodSearchViewModel.WidthValue,
                HeightValue = goodSearchViewModel.HeightValue,
                GoodCategoryName = goodSearchViewModel.GoodCategoryName,
                IsActive = goodSearchViewModel.IsActive,
                DiameterValue = goodSearchViewModel.DiameterValue,
                GoodPatternName = goodSearchViewModel.GoodPatternName,
                NationalCode = goodSearchViewModel.NationalCode,
                WeightPack = goodSearchViewModel.WeightPack,
                WeightGoods = goodSearchViewModel.WeightGoods

            };

            var _res = dbContext.Connection.Query<GoodSearchResponseModel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }
    }
}
