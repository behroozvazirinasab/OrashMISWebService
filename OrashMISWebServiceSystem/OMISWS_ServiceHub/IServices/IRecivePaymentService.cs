using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;

namespace OMISWS_ServiceHub.Services
{
    public interface IRecivePaymentService
    {
        string getxml(List<RecivePaymentDataModel> data);
        Task<Resmodel<IEnumerable<ResponseModel1>>> runRecivePaymentsp(RecivePaymentInputModel recivePaymentInput);
    }
}