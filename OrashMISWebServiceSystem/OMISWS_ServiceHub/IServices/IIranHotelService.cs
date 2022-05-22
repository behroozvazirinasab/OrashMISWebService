using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;

namespace OMISWS_ServiceHub.Services
{
    public interface IIranHotelService
    {
        string getxml(List<IranHotelDataModel> data);
        List<ResponseModel1> runiranhotelsp(string Custcode, string Custname, string Custprice, string Custdesc, short Turnovercode, string Date, List<IranHotelDataModel> supplier, List<IranHotelDataModel> bank);
    }
}