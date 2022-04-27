using OMISDataModel.ViewModels;
using SharedStorage.Models;

namespace OMISServiceHub.IServices
{
    public interface IGoodService
    {
        Task<ResponseModel<bool>> runInsertGoodsp(GoodViewModel good);
    }
}