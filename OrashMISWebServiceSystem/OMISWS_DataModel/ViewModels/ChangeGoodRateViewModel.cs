using OMISWS_DataModel.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_DataModel.ViewModels
{
    public class ChangeGoodRateViewModel : IChangeGoodRateBaseModel
    {
        
        public string? GoodCode { get; set; }
        public long? StorageCode { get; set; }
        public decimal? FiPrice1 { get; set; }
        public decimal? OffPercent1 { get; set; }
        public decimal? FiPrice2 { get; set; }
        public decimal? OffPercent2 { get; set; }
        public decimal? FiPrice3 { get; set; }
        public decimal? OffPercent3 { get; set; }
        public long? UserIdRef { get; set; }
    }
}
