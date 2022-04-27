using Dapper;
using Newtonsoft.Json;
using OMISDataModel.Models;
using OMISDataModel.ViewModels;
using OMISServiceHub.Contexts;
using OMISServiceHub.IServices;
using SharedStorage.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OMISServiceHub.Services
{
    public partial class GoodService : IGoodService
    {
        private readonly OMISDBContext dbContext;

        public GoodService(OMISDBContext _dbContext)
        {
            dbContext = _dbContext;

            //var connStr = ConfigurationManager.ConnectionStrings["ORM"].ConnectionString;

            //connection = new SqlConnection(connStr);
        }

        public async Task<ResponseModel<bool>> runInsertGoodsp(GoodViewModel good)
        {
            var model = Maping(good);

            var query = "InsertGoods";

            //var queryParams = new DynamicParameters();
            //queryParams.Add("@StateCodeRef", model.StateCodeRef, DbType.Int64, ParameterDirection.Input);

            var queryParams = new
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
                await dbContext.Connection.ExecuteAsync(query, queryParams, commandType: CommandType.StoredProcedure);

                return new ResponseModel<bool>()
                {
                    Result = true,
                    HasError = false
                };
            }
            catch (Exception)
            {
                throw;
            }

            //return _res.ToList();
        }
    }
}
