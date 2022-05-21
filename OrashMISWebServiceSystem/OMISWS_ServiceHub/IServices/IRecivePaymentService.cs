using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;

namespace OMISWS_ServiceHub.Services
{
    public interface IRecivePaymentService
    {
        string getxml(List<RecivePaymentDataModel> data);
        List<ResponseModel> runRecivePaymentsp(List<RecivePaymentDataModel> Value, long Createuser, string Createdate, string Createtime);
    }
}