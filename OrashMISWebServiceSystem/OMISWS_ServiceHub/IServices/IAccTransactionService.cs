using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;

namespace OMISWS_ServiceHub.Services
{
    public interface IAccTransactionService
    {
        string getxml(List<FactorDataModel> data);
        List<ResponseModel1> runAccTransactionsp(List<FactorDataModel> Value, long Createuser, string Createdate, string Createtime);
    }
}