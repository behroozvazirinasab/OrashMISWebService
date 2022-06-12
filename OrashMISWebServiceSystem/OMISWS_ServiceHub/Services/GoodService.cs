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



        public async Task<Resmodel<IEnumerable<ResponseModel2>>> runInsertGoodsp(GoodInsertViewModel goodInsert)
        {
            //var model = MapForInsert(goodInsert);

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
                Code = goodInsert.Code,
                Name = goodInsert.Name,
                Type = goodInsert.Type,
                UnitIdRef = goodInsert.UnitIdRef,
                MainGroupCodeRef = goodInsert.MainGroupCodeRef,
                SecondGroupCodeRef = goodInsert.SecondGroupCodeRef,
                Pic = goodInsert.Pic,
                IsAdded = goodInsert.IsAdded,
                ImageData = goodInsert.ImageData,
                IsBuyAdded = goodInsert.IsBuyAdded,
                Serial = goodInsert.Serial,
                FiPrice1 = goodInsert.FiPrice1,
                OffPercent1 = goodInsert.OffPercent1,
                FiPrice2 = goodInsert.FiPrice2,
                OffPercent2 = goodInsert.OffPercent2,
                FiPrice3 = goodInsert.FiPrice3,
                OffPercent3 = goodInsert.OffPercent3,
                SaleName = goodInsert.SaleName,
                UnitPackingCodeRef = goodInsert.UnitPackingCodeRef,
                TaxPercent = goodInsert.TaxPercent,
                lengthValue = goodInsert.lengthValue,
                WidthValue = goodInsert.WidthValue,
                HeightValue = goodInsert.HeightValue,
                GoodCategoryIdRef = goodInsert.GoodCategoryIdRef,
                IsActive = goodInsert.IsActive,
                DiameterValue = goodInsert.DiameterValue,
                SerialsControl = goodInsert.SerialsControl,
                PatternIdRef = goodInsert.PatternIdRef,
                NationalCode = goodInsert.NationalCode,
                WeightPack = goodInsert.WeightPack,
                WeightGoods = goodInsert.WeightGoods,
                CriterionWeight = goodInsert.CriterionWeight,
                DimensionsLengthPack = goodInsert.DimensionsLengthPack,
                DimensionsWidthPack = goodInsert.DimensionsWidthPack,
                DimensionsHeightPack = goodInsert.DimensionsHeightPack,
                DimensionsLengthGoods = goodInsert.DimensionsLengthGoods,
                DimensionsWidthGoods = goodInsert.DimensionsWidthGoods,
                DimensionsHeightGoods = goodInsert.DimensionsHeightGoods,
                CriterionDimensions = goodInsert.CriterionDimensions
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
