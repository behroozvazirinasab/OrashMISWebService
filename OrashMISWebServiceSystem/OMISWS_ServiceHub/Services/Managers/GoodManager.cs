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
        public GoodInsertModel MapForInsert(GoodInsertViewModel viewModel)
        {
            return new GoodInsertModel()
            {
                Code = viewModel.Code,
                Name = viewModel.Name,
                Type = viewModel.Type,
                UnitIdRef = viewModel.UnitIdRef,
                MainGroupCodeRef = viewModel.MainGroupCodeRef,
                SecondGroupCodeRef = viewModel.SecondGroupCodeRef,
                Pic = viewModel.Pic,
                IsAdded = viewModel.IsAdded,
                ImageData = viewModel.ImageData,
                IsBuyAdded = viewModel.IsBuyAdded,
                Serial = viewModel.Serial,
                FiPrice1 = viewModel.FiPrice1,
                OffPercent1 = viewModel.OffPercent1,
                FiPrice2 = viewModel.FiPrice2,
                OffPercent2 = viewModel.OffPercent2,
                FiPrice3 = viewModel.FiPrice3,
                OffPercent3 = viewModel.OffPercent3,
                SaleName = viewModel.SaleName,
                UnitPackingCodeRef = viewModel.UnitPackingCodeRef,
                TaxPercent = viewModel.TaxPercent,
                lengthValue = viewModel.lengthValue,
                WidthValue = viewModel.WidthValue,
                HeightValue = viewModel.HeightValue,
                GoodCategoryIdRef = viewModel.GoodCategoryIdRef,
                IsActive = viewModel.IsActive,
                DiameterValue = viewModel.DiameterValue,
                SerialsControl = viewModel.SerialsControl,
                PatternIdRef = viewModel.PatternIdRef,
                NationalCode = viewModel.NationalCode,
                WeightPack = viewModel.WeightPack,
                WeightGoods = viewModel.WeightGoods,
                CriterionWeight = viewModel.CriterionWeight,
                DimensionsLengthPack = viewModel.DimensionsLengthPack,
                DimensionsWidthPack = viewModel.DimensionsWidthPack,
                DimensionsHeightPack = viewModel.DimensionsHeightPack,
                DimensionsLengthGoods = viewModel.DimensionsLengthGoods,
                DimensionsWidthGoods = viewModel.DimensionsWidthGoods,
                DimensionsHeightGoods = viewModel.DimensionsHeightGoods,
                CriterionDimensions = viewModel.CriterionDimensions
            };
        }
    }
}
