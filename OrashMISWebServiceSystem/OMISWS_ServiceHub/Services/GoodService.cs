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



        public List<ResponseModel2> runInsertGoodsp(GoodViewModel goodViewModel)
        {
            var query = "InsertGoods";

            var queryparams = new
            {
                Code = goodViewModel.Code,
                Name = goodViewModel.Name,
                Type = goodViewModel.Type,
                UnitIdRef = goodViewModel.UnitIdRef,
                MainGroupCodeRef = goodViewModel.MainGroupCodeRef,
                SecondGroupCodeRef = goodViewModel.SecondGroupCodeRef,
                Pic = goodViewModel.Pic,
                IsAdded = goodViewModel.IsAdded,
                ImageData = goodViewModel.ImageData,
                IsBuyAdded = goodViewModel.IsBuyAdded,
                Serial = goodViewModel.Serial,
                FiPrice1 = goodViewModel.FiPrice1,
                OffPercent1 = goodViewModel.OffPercent1,
                FiPrice2 = goodViewModel.FiPrice2,
                OffPercent2 = goodViewModel.OffPercent2,
                FiPrice3 = goodViewModel.FiPrice3,
                OffPercent3 = goodViewModel.OffPercent3,
                SaleName = goodViewModel.SaleName,
                UnitPackingCodeRef = goodViewModel.UnitPackingCodeRef,
                TaxPercent = goodViewModel.TaxPercent,
                lengthValue = goodViewModel.lengthValue,
                WidthValue = goodViewModel.WidthValue,
                HeightValue = goodViewModel.HeightValue,
                GoodCategoryIdRef = goodViewModel.GoodCategoryIdRef,
                IsActive = goodViewModel.IsActive,
                DiameterValue = goodViewModel.DiameterValue,
                SerialsControl = goodViewModel.SerialsControl,
                PatternIdRef = goodViewModel.PatternIdRef,
                NationalCode = goodViewModel.NationalCode,
                WeightPack = goodViewModel.WeightPack,
                WeightGoods = goodViewModel.WeightGoods,
                CriterionWeight = goodViewModel.CriterionWeight,
                DimensionsLengthPack = goodViewModel.DimensionsLengthPack,
                DimensionsWidthPack = goodViewModel.DimensionsWidthPack,
                DimensionsHeightPack = goodViewModel.DimensionsHeightPack,
                DimensionsLengthGoods = goodViewModel.DimensionsLengthGoods,
                DimensionsWidthGoods = goodViewModel.DimensionsWidthGoods,
                DimensionsHeightGoods = goodViewModel.DimensionsHeightGoods,
                CriterionDimensions = goodViewModel.CriterionDimensions

            };

            var _res = dbContext.Connection.Query<ResponseModel2>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }

    }
}
