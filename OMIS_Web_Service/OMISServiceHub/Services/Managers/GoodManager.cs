using OMISDataModel.Models;
using OMISDataModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISServiceHub.Services
{
    public partial class GoodService 
    {
        private GoodModel Maping(GoodViewModel viewModel)
        {
            return new GoodModel()
            {
                Code = Code.viewModel,
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
        }
    }
}