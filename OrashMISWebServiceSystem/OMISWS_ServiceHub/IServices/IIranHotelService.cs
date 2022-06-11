using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;

namespace OMISWS_ServiceHub.Services
{
    public interface IIranHotelService
    {
        string getxml(List<IranHotelDataModel> data);
        Task<Resmodel<IEnumerable<ResponseModel1>>> runiranhotelsp(IranHotelInputModel iranHotelInput);
    }
}