using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_ServiceHub.Services
{
    public partial class ChangeGoodRateService : IChangeGoodRateService
    {
        public ChangeGoodRateModel MapForInsert(ChangeGoodRateViewModel rateInput)
        {
            return new ChangeGoodRateModel()
            {
                GoodCode = rateInput.GoodCode,
                StorageCode = rateInput.StorageCode,
                FiPrice1 = rateInput.FiPrice1,
                OffPercent1 = rateInput.OffPercent1,
                FiPrice2 = rateInput.FiPrice2,
                OffPercent2 = rateInput.OffPercent2,
                FiPrice3 = rateInput.FiPrice3,
                OffPercent3 = rateInput.OffPercent3,
                UserIdRef = rateInput.UserIdRef
            };


        }
    }
}