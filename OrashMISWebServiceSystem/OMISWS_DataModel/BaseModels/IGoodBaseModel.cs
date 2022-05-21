namespace OMISWS_DataModel.BaseModels
{
    public interface IGoodBaseModel
    {
         string Code { get; set; }
         string Name { get; set; }
         long? Type { get; set; }
         long? UnitIdRef { get; set; }
         long? MainGroupCodeRef { get; set; }
         long? SecondGroupCodeRef { get; set; }
         byte? Pic { get; set; }              //
         Boolean? IsAdded { get; set; }
         byte[] ImageData { get; set; }      //
         Boolean? IsBuyAdded { get; set; }
         string Serial { get; set; }
         decimal? FiPrice1 { get; set; }
         decimal? OffPercent1 { get; set; }
         decimal? FiPrice2 { get; set; }
         decimal? OffPercent2 { get; set; }
         decimal? FiPrice3 { get; set; }
         decimal? OffPercent3 { get; set; }
         string SaleName { get; set; }
         long? UnitPackingCodeRef { get; set; }
         decimal? TaxPercent { get; set; }
         decimal? lengthValue { get; set; }
         decimal? WidthValue { get; set; }
         decimal? HeightValue { get; set; }
         long? GoodCategoryIdRef { get; set; }
         Boolean? IsActive { get; set; }
         decimal? DiameterValue { get; set; }
         Boolean? SerialsControl { get; set; }
         long? PatternIdRef { get; set; }
         string NationalCode { get; set; }
         decimal? WeightPack { get; set; }
         decimal? WeightGoods { get; set; }
         long? CriterionWeight { get; set; }
         decimal? DimensionsLengthPack { get; set; }
         decimal? DimensionsWidthPack { get; set; }
         decimal? DimensionsHeightPack { get; set; }
         decimal? DimensionsLengthGoods { get; set; }
         decimal? DimensionsWidthGoods { get; set; }
         decimal? DimensionsHeightGoods { get; set; }
         long? CriterionDimensions { get; set; }
    }
}