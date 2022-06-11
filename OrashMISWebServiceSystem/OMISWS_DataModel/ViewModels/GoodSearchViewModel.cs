using OMISWS_DataModel.BaseModels;

namespace OMISWS_DataModel.ViewModels
{
    public class GoodSearchViewModel /*: IGoodBaseModel*/
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public long? Type { get; set; }
        public string UnitsName { get; set; }
        public string MainGroupName { get; set; }
        public string SecondGroupName { get; set; }
        public string Serial { get; set; }
        public decimal? FiPrice1 { get; set; }
        public decimal? OffPercent1 { get; set; }
        public decimal? FiPrice2 { get; set; }
        public decimal? OffPercent2 { get; set; }
        public decimal? FiPrice3 { get; set; }
        public decimal? OffPercent3 { get; set; }
        public string SaleName { get; set; }
        public string UnitPackingName { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? lengthValue { get; set; }
        public decimal? WidthValue { get; set; }
        public decimal? HeightValue { get; set; }
        public string GoodCategoryName { get; set; }
        public string IsActive { get; set; }
        public decimal? DiameterValue { get; set; }
        public string GoodPatternName { get; set; }
        public string NationalCode { get; set; }
        public decimal? WeightPack { get; set; }
        public decimal? WeightGoods { get; set; }
    }
}
