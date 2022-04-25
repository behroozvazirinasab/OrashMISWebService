namespace OMISDataModel.BaseModels
{
    public interface IGoodBaseModel
    {
        string Code { get; set; }
        long? CriterionDimensions { get; set; }
        long? CriterionWeight { get; set; }
        decimal? DiameterValue { get; set; }
        decimal? DimensionsHeightGoods { get; set; }
        decimal? DimensionsHeightPack { get; set; }
        decimal? DimensionsLengthGoods { get; set; }
        decimal? DimensionsLengthPack { get; set; }
        decimal? DimensionsWidthGoods { get; set; }
        decimal? DimensionsWidthPack { get; set; }
        decimal? FiPrice1 { get; set; }
        decimal? FiPrice2 { get; set; }
        decimal? FiPrice3 { get; set; }
        long? GoodCategoryIdRef { get; set; }
        decimal? HeightValue { get; set; }
        byte[]? ImageData { get; set; }
        bool? IsActive { get; set; }
        bool? IsAdded { get; set; }
        bool? IsBuyAdded { get; set; }
        decimal? lengthValue { get; set; }
        long? MainGroupCodeRef { get; set; }
        string Name { get; set; }
        string NationalCode { get; set; }
        decimal? OffPercent1 { get; set; }
        decimal? OffPercent2 { get; set; }
        decimal? OffPercent3 { get; set; }
        long? PatternIdRef { get; set; }
        byte? Pic { get; set; }
        string SaleName { get; set; }
        long? SecondGroupCodeRef { get; set; }
        string Serial { get; set; }
        bool? SerialsControl { get; set; }
        decimal? TaxPercent { get; set; }
        long? Type { get; set; }
        long? UnitIdRef { get; set; }
        long? UnitPackingCodeRef { get; set; }
        decimal? WeightGoods { get; set; }
        decimal? WeightPack { get; set; }
        decimal? WidthValue { get; set; }
    }
}