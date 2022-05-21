using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;

namespace OMISWS_ServiceHub.Services
{
    public interface IFactorService
    {
        string getxml(List<FactorModel> data);
        List<ResponseModel> runFactorsp(List<FactorModel> Value, long Createuser, string Createdate, string Createtime, long? VisitorId, decimal? VisitorPrice);
    }
}