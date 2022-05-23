using OMISWS_DataModel.BaseModels;

namespace OMISWS_DataModel.Models
{
    public class GoodInsertModel : IGoodBaseModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public long? Type { get; set; }
        public long? UnitIdRef { get; set; }
        public long? MainGroupCodeRef { get; set; }
        public long? SecondGroupCodeRef { get; set; }
        public byte? Pic { get; set; }              //
        public Boolean? IsAdded { get; set; }
        public byte[] ImageData { get; set; }      //
        public Boolean? IsBuyAdded { get; set; }
        public string Serial { get; set; }
        public decimal? FiPrice1 { get; set; }
        public decimal? OffPercent1 { get; set; }
        public decimal? FiPrice2 { get; set; }
        public decimal? OffPercent2 { get; set; }
        public decimal? FiPrice3 { get; set; }
        public decimal? OffPercent3 { get; set; }
        public string SaleName { get; set; }
        public long? UnitPackingCodeRef { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? lengthValue { get; set; }
        public decimal? WidthValue { get; set; }
        public decimal? HeightValue { get; set; }
        public long? GoodCategoryIdRef { get; set; }
        public Boolean? IsActive { get; set; }
        public decimal? DiameterValue { get; set; }
        public Boolean? SerialsControl { get; set; }
        public long? PatternIdRef { get; set; }
        public string NationalCode { get; set; }
        public decimal? WeightPack { get; set; }
        public decimal? WeightGoods { get; set; }
        public long? CriterionWeight { get; set; }
        public decimal? DimensionsLengthPack { get; set; }
        public decimal? DimensionsWidthPack { get; set; }
        public decimal? DimensionsHeightPack { get; set; }
        public decimal? DimensionsLengthGoods { get; set; }
        public decimal? DimensionsWidthGoods { get; set; }
        public decimal? DimensionsHeightGoods { get; set; }
        public long? CriterionDimensions { get; set; }
    }
}
