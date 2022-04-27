using Microsoft.AspNetCore.Mvc;
using OMISDataModel.ViewModels;
using OMISServiceHub.IServices;
using OMISServiceHub.Services;
using SharedStorage.Extensions;
using SharedStorage.Models;
//using System.Web.Http;

namespace OMISServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodController : ControllerBase
    {
        private readonly IGoodService _goodService;

        public GoodController (IGoodService goodService)
        {
            _goodService = goodService; 
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GoodViewModel good)
        {
            try
            {
                var result = await _goodService.runInsertGoodsp(good);
                return Ok(result);
            }
            catch (Exception e)
            {
                var _Result = new ResponseModel<bool>().GetErrorResponseToString(e);
                return Problem(_Result);
            }
        }
    }
}
