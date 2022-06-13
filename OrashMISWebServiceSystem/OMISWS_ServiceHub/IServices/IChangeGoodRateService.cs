using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;

namespace OMISWS_ServiceHub.IServices
{
    public interface IChangeGoodRateService
    {
        Task<Resmodel<IEnumerable<ResponseModel4>>> runChangeGoodRatesp(ChangeGoodRateViewModel rateInput);

        ChangeGoodRateModel MapForInsert(ChangeGoodRateViewModel rateInput);
    }
}