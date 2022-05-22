using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_DataModel.ResponseModels
{
    public class ResponseModel
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? UnitName { get; set; }
        public string? MainGroupName { get; set; }
        public string? SeconfGroupName { get; set; }
        public byte? Pic { get; set; }
        public string? IsAdded { get; set; }
        public byte[]? ImageData { get; set; }
        public string? IsBuyAdded { get; set; }
        public string? Serial { get; set; }
        public string? FiPrice1 { get; set; }
        public string? OffPercent1 { get; set; }
        public string? FiPrice2 { get; set; }
        public string? OffPercent2 { get; set; }
        public string? FiPrice3 { get; set; }
        public string? OffPercent3 { get; set; }
        public string? SaleName { get; set; }
        public string? TaxPercent { get; set; }
        public string? lengthValue { get; set; }
        public string? WidthValue { get; set; }
        public string? HeightValue { get; set; }
        public string? IsActive { get; set; }
        public string? DiameterValue { get; set; }
        public string? NationalCode { get; set; }
        public string? WeightPack { get; set; }
        public string? WeightGoods { get; set; }
        public long? CriterionWeight { get; set; }
        public string? DimensionsLengthPack { get; set; }
        public string? DimensionsWidthPack { get; set; }
        public string? DimensionsHeightPack { get; set; }
        public string? DimensionsLengthGoods { get; set; }
        public string? DimensionsWidthGoods { get; set; }
        public string? DimensionsHeightGoods { get; set; }
        public long? CriterionDimensions { get; set; }
    }
}
