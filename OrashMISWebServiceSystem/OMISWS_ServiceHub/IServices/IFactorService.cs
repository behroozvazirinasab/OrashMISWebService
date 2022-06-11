using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;

namespace OMISWS_ServiceHub.Services
{
    public interface IFactorService
    {


        string getxml(List<FactorModel> data);


        Task<ResponseModel1> runFactorsp(FactorInputModel input);


    }
}