using Dapper;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.Contexts;
using OMISWS_ServiceHub.IServices;
using System.Data;

namespace OMISWS_ServiceHub.Services
{
    public partial class GoodService : IGoodService
    {
        private readonly OMISWSDBContext dbContext;

        public GoodService(OMISWSDBContext _dbContext)
        {
            dbContext = _dbContext;
        }



        public async Task<Resmodel<IEnumerable<ResponseModel2>>> runInsertGoodsp(GoodInsertViewModel goodInsertInput)
        {
            var model = MapForInsert(goodInsertInput);

            var query = "InsertGoods";


            /*var queryParams = new DynamicParameters();
            queryParams.Add("@Code", model.Code, DbType.String, ParameterDirection.Input);
            queryParams.Add("@Name", model.Name, DbType.String, ParameterDirection.Input);
            queryParams.Add("@Type", model.Type, DbType.Int64, ParameterDirection.Input);
            queryParams.Add("@UnitIdRef", model.UnitIdRef, DbType.Int64, ParameterDirection.Input);
            queryParams.Add("@MainGroupCodeRef", model.MainGroupCodeRef, DbType.Int64, ParameterDirection.Input);
            queryParams.Add("@SecondGroupCodeRef", model.SecondGroupCodeRef, DbType.Int64, ParameterDirection.Input);
            queryParams.Add("@Pic", model.Pic, DbType.Byte, ParameterDirection.Input);
            queryParams.Add("@IsAdded", model.IsAdded, DbType.Boolean, ParameterDirection.Input);
            queryParams.Add("@ImageData", model.ImageData, DbType.Byte, ParameterDirection.Input);
            queryParams.Add("@IsBuyAdded", model.IsBuyAdded, DbType.Boolean, ParameterDirection.Input);
            queryParams.Add("@Serial", model.Serial, DbType.String, ParameterDirection.Input);
            queryParams.Add("@FiPrice1", model.FiPrice1, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@OffPercent1", model.OffPercent1, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@FiPrice2", model.FiPrice2, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@OffPercent2", model.OffPercent2, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@FiPrice3", model.FiPrice3, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@OffPercent3", model.OffPercent3, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@SaleName", model.SaleName, DbType.String, ParameterDirection.Input);
            queryParams.Add("@UnitPackingCodeRef", model.UnitPackingCodeRef, DbType.Int64, ParameterDirection.Input);
            queryParams.Add("@TaxPercent", model.TaxPercent, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@lengthValue", model.lengthValue, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@WidthValue", model.WidthValue, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@HeightValue", model.HeightValue, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@GoodCategoryIdRef", model.GoodCategoryIdRef, DbType.Int64, ParameterDirection.Input);
            queryParams.Add("@IsActive", model.IsActive, DbType.Boolean, ParameterDirection.Input);
            queryParams.Add("@DiameterValue", model.DiameterValue, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@SerialsControl", model.SerialsControl, DbType.Boolean, ParameterDirection.Input);
            queryParams.Add("@PatternIdRef", model.PatternIdRef, DbType.Int64, ParameterDirection.Input);
            queryParams.Add("@NationalCode", model.NationalCode, DbType.String, ParameterDirection.Input);
            queryParams.Add("@WeightPack", model.WeightPack, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@WeightGoods", model.WeightGoods, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@CriterionWeight", model.CriterionWeight, DbType.Int64, ParameterDirection.Input);
            queryParams.Add("@DimensionsLengthPack", model.DimensionsLengthPack, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@DimensionsWidthPack", model.DimensionsWidthPack, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@DimensionsHeightPack", model.DimensionsHeightPack, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@DimensionsLengthGoods", model.DimensionsLengthGoods, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@DimensionsWidthGoods", model.DimensionsWidthGoods, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@DimensionsHeightGoods", model.DimensionsHeightGoods, DbType.Decimal, ParameterDirection.Input);
            queryParams.Add("@CriterionDimensions", model.CriterionDimensions, DbType.Int64, ParameterDirection.Input);*/


            var queryparams = new
            {
                Code = model.Code,
                Name = model.Name,
                Type = model.Type,
                UnitIdRef = model.UnitIdRef,
                MainGroupCodeRef = model.MainGroupCodeRef,
                SecondGroupCodeRef = model.SecondGroupCodeRef,
                Pic = model.Pic,
                IsAdded = model.IsAdded,
                ImageData = model.ImageData,
                IsBuyAdded = model.IsBuyAdded,
                Serial = model.Serial,
                FiPrice1 = model.FiPrice1,
                OffPercent1 = model.OffPercent1,
                FiPrice2 = model.FiPrice2,
                OffPercent2 = model.OffPercent2,
                FiPrice3 = model.FiPrice3,
                OffPercent3 = model.OffPercent3,
                SaleName = model.SaleName,
                UnitPackingCodeRef = model.UnitPackingCodeRef,
                TaxPercent = model.TaxPercent,
                lengthValue = model.lengthValue,
                WidthValue = model.WidthValue,
                HeightValue = model.HeightValue,
                GoodCategoryIdRef = model.GoodCategoryIdRef,
                IsActive = model.IsActive,
                DiameterValue = model.DiameterValue,
                SerialsControl = model.SerialsControl,
                PatternIdRef = model.PatternIdRef,
                NationalCode = model.NationalCode,
                WeightPack = model.WeightPack,
                WeightGoods = model.WeightGoods,
                CriterionWeight = model.CriterionWeight,
                DimensionsLengthPack = model.DimensionsLengthPack,
                DimensionsWidthPack = model.DimensionsWidthPack,
                DimensionsHeightPack = model.DimensionsHeightPack,
                DimensionsLengthGoods = model.DimensionsLengthGoods,
                DimensionsWidthGoods = model.DimensionsWidthGoods,
                DimensionsHeightGoods = model.DimensionsHeightGoods,
                CriterionDimensions = model.CriterionDimensions
            };

            try
            {
                var _res = await dbContext.Connection.QueryAsync<ResponseModel2>(query, queryparams, commandType: CommandType.StoredProcedure);

                return new Resmodel<IEnumerable<ResponseModel2>>()
                {
                    Result = _res
                };
            }
            catch (Exception) { throw; }
        }
    }




        //public List<GoodSearchResponseModel> runSearchGoodsp(GoodSearchViewModel goodSearchViewModel)
        //{
        //    var query = "SearchGoods";

        //    var queryparams = new
        //    {
        //        Code = goodSearchViewModel.Code,
        //        Name = goodSearchViewModel.Name,
        //        Type = goodSearchViewModel.Type,
        //        UnitsName = goodSearchViewModel.UnitsName,
        //        MainGroupName = goodSearchViewModel.MainGroupName,
        //        SecondGroupName = goodSearchViewModel.SecondGroupName,
        //        Serial = goodSearchViewModel.Serial,
        //        FiPrice1 = goodSearchViewModel.FiPrice1,
        //        OffPercent1 = goodSearchViewModel.OffPercent1,
        //        FiPrice2 = goodSearchViewModel.FiPrice2,
        //        OffPercent2 = goodSearchViewModel.OffPercent2,
        //        FiPrice3 = goodSearchViewModel.FiPrice3,
        //        OffPercent3 = goodSearchViewModel.OffPercent3,
        //        SaleName = goodSearchViewModel.SaleName,
        //        UnitPackingName = goodSearchViewModel.UnitPackingName,
        //        TaxPercent = goodSearchViewModel.TaxPercent,
        //        lengthValue = goodSearchViewModel.lengthValue,
        //        WidthValue = goodSearchViewModel.WidthValue,
        //        HeightValue = goodSearchViewModel.HeightValue,
        //        GoodCategoryName = goodSearchViewModel.GoodCategoryName,
        //        IsActive = goodSearchViewModel.IsActive,
        //        DiameterValue = goodSearchViewModel.DiameterValue,
        //        GoodPatternName = goodSearchViewModel.GoodPatternName,
        //        NationalCode = goodSearchViewModel.NationalCode,
        //        WeightPack = goodSearchViewModel.WeightPack,
        //        WeightGoods = goodSearchViewModel.WeightGoods

        //    };

        //    var _res = dbContext.Connection.Query<GoodSearchResponseModel>(query, queryparams, commandType: CommandType.StoredProcedure);

        //    return _res.ToList();
        //}
    
}
