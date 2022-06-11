using OMISWS_DataModel.Models;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;

namespace OMISWS_ServiceHub.IServices
{
    public interface IGoodService 
    {
        Task<Resmodel<IEnumerable<ResponseModel2>>> runInsertGoodsp(GoodInsertViewModel goodInsertInput);

        GoodInsertModel MapForInsert(GoodInsertViewModel goodInsertInput);

        
    }
}