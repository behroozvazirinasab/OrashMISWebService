namespace OMISWS_DataModel.BaseModels
{
    public interface IGoodBaseModel
    {
        /*string Code { get; set; }
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
        byte[] ImageData { get; set; }
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
        decimal? WidthValue { get; set; }*/



        public string Code { get; set; }
        public string Name { get; set; }
        public long? Type { get; set; }
        public decimal? FiPrice1 { get; set; }
        public decimal? OffPercent1 { get; set; }
        public decimal? FiPrice2 { get; set; }
        public decimal? OffPercent2 { get; set; }
        public decimal? FiPrice3 { get; set; }
        public decimal? OffPercent3 { get; set; }
        public string SaleName { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? lengthValue { get; set; }
        public decimal? WidthValue { get; set; }
        public decimal? HeightValue { get; set; }
        public decimal? DiameterValue { get; set; }
        public string NationalCode { get; set; }
        public decimal? WeightPack { get; set; }
        public decimal? WeightGoods { get; set; }
        public string Serial { get; set; }
        //public Boolean? IsActive { get; set; }



        //----insert

        /*public long? UnitIdRef { get; set; }
        public long? MainGroupCodeRef { get; set; }
        public long? SecondGroupCodeRef { get; set; }
        public byte? Pic { get; set; }              //
        public Boolean? IsAdded { get; set; }
        public byte[] ImageData { get; set; }      //
        public Boolean? IsBuyAdded { get; set; }
        public long? UnitPackingCodeRef { get; set; }
        public long? GoodCategoryIdRef { get; set; }
        public Boolean? SerialsControl { get; set; }
        public long? PatternIdRef { get; set; }
        public long? CriterionWeight { get; set; }
        public decimal? DimensionsLengthPack { get; set; }
        public decimal? DimensionsWidthPack { get; set; }
        public decimal? DimensionsHeightPack { get; set; }
        public decimal? DimensionsLengthGoods { get; set; }
        public decimal? DimensionsWidthGoods { get; set; }
        public decimal? DimensionsHeightGoods { get; set; }
        public long? CriterionDimensions { get; set; }



        //---- search

        public string UnitsName { get; set; }
        public string MainGroupName { get; set; }
        public string SecondGroupName { get; set; }
        public string UnitPackingName { get; set; }
        public string GoodCategoryName { get; set; }
        public string GoodPatternName { get; set; }*/
    }
}