using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;

namespace OMISWS_ServiceHub.IServices
{
    public interface IPersonService
    {
        List<ResponseModel2> runInsertPersonsp(PersonInsertViewModel personInsertViewModel);
        List<PersonSearchResponseModel> runSearchPersonsp(PersonSearchViewModel personSearchViewModel);
    }
}