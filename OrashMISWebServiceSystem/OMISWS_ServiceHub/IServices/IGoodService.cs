using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;

namespace OMISWS_ServiceHub.IServices
{
    public interface IGoodService
    {
        List<ResponseModel2> runInsertGoodsp(GoodInsertViewModel good);

        List<GoodSearchResponseModel> runSearchGoodsp(GoodSearchViewModel goodSearchViewModel);
    }
}