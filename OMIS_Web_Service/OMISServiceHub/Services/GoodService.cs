using Dapper;
using Newtonsoft.Json;
using OMISDataModel.Models;
using OMISDataModel.ViewModels;
using OMISServiceHub.Contexts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OMISServiceHub.Services
{
    public partial class GoodService
    {
        private readonly OMISDBContext dbContext;

        public GoodService(OMISDBContext _dbContext)
        {
            dbContext = _dbContext;

            //var connStr = ConfigurationManager.ConnectionStrings["ORM"].ConnectionString;

            //connection = new SqlConnection(connStr);
        }

        public List<ResponseModel> runInsertGoodsp(GoodViewModel good/*string Code, string Name, long? Type, long? UnitIdRef, long? MainGroupCodeRef, long? SecondGroupCodeRef, byte? Pic, Boolean? IsAdded, byte[] ImageData, Boolean? IsBuyAdded, string Serial, decimal? FiPrice1, decimal? OffPercent1, decimal? FiPrice2, decimal? OffPercent2, decimal? FiPrice3, decimal? OffPercent3, string SaleName, long? UnitPackingCodeRef, decimal? TaxPercent, decimal? lengthValue, decimal? WidthValue, decimal? HeightValue, long? GoodCategoryIdRef, Boolean? IsActive, decimal? DiameterValue, Boolean? SerialsControl, long? PatternIdRef, string NationalCode, decimal? WeightPack, decimal? WeightGoods, long? CriterionWeight, decimal? DimensionsLengthPack, decimal? DimensionsWidthPack, decimal? DimensionsHeightPack, decimal? DimensionsLengthGoods, decimal? DimensionsWidthGoods, decimal? DimensionsHeightGoods, long? CriterionDimensions*/)
        {
            var model = Maping(good);

            var query = "InsertGoods";

            var queryparams = new
            {
                Code = Code,
                Name = Name,
                Type = Type,
                UnitIdRef = UnitIdRef,
                MainGroupCodeRef = MainGroupCodeRef,
                SecondGroupCodeRef = SecondGroupCodeRef,
                Pic = Pic,
                IsAdded = IsAdded,
                ImageData = ImageData,
                IsBuyAdded = IsBuyAdded,
                Serial = Serial,
                FiPrice1 = FiPrice1,
                OffPercent1 = OffPercent1,
                FiPrice2 = FiPrice2,
                OffPercent2 = OffPercent2,
                FiPrice3 = FiPrice3,
                OffPercent3 = OffPercent3,
                SaleName = SaleName,
                UnitPackingCodeRef = UnitPackingCodeRef,
                TaxPercent = TaxPercent,
                lengthValue = lengthValue,
                WidthValue = WidthValue,
                HeightValue = HeightValue,
                GoodCategoryIdRef = GoodCategoryIdRef,
                IsActive = IsActive,
                DiameterValue = DiameterValue,
                SerialsControl = SerialsControl,
                PatternIdRef = PatternIdRef,
                NationalCode = NationalCode,
                WeightPack = WeightPack,
                WeightGoods = WeightGoods,
                CriterionWeight = CriterionWeight,
                DimensionsLengthPack = DimensionsLengthPack,
                DimensionsWidthPack = DimensionsWidthPack,
                DimensionsHeightPack = DimensionsHeightPack,
                DimensionsLengthGoods = DimensionsLengthGoods,
                DimensionsWidthGoods = DimensionsWidthGoods,
                DimensionsHeightGoods = DimensionsHeightGoods,
                CriterionDimensions = CriterionDimensions

            };

            var _res = dbContext.Connection.Query<ResponseModel>(query, queryparams, commandType: CommandType.StoredProcedure);

            return _res.ToList();
        }
    }
}
