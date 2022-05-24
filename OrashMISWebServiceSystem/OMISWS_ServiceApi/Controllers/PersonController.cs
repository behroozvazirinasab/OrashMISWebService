using Microsoft.AspNetCore.Mvc;
using OMISWS_DataModel.ResponseModels;
using OMISWS_DataModel.ViewModels;
using OMISWS_ServiceHub.IServices;

namespace OMISWS_ServiceApi.Controllers
{
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }



        [HttpPost]
        [Route("api/OrashMISWebService/InsertPerson")]
        public List<ResponseModel2> Post([FromBody] PersonInsertViewModel person)
        {

            var _res = _personService.runInsertPersonsp(person);
            return _res.ToList();
        }





        [HttpPost]
        [Route("api/OrashMISWebService/SearchPerson")]
        public List<PersonSearchResponseModel> Post([FromBody] PersonSearchViewModel person)
        {

            var _res = _personService.runSearchPersonsp(person);
            return _res.ToList();
        }

    }
}
