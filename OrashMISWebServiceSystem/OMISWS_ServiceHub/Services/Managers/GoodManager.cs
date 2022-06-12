using OMISWS_DataModel.Models;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_ServiceHub.Services
{
    public partial class GoodService : IGoodService
    {
        public GoodInsertModel MapForInsert(GoodInsertViewModel goodInsert)
        {
            return new GoodInsertModel()
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
        }
    }
}
