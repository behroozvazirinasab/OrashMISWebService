using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;

namespace OMISWS_ServiceHub.Services
{
    public interface IAccTransactionService
    {


        string getxml(List<AccTransactionDataModel> data);


        Task<Resmodel<IEnumerable<ResponseModel3>>> runAccTransactionsp(AccTransactionInputModel accInput);


    }
}