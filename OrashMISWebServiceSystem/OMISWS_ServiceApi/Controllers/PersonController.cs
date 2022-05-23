using Microsoft.AspNetCore.Mvc;

namespace OMISWS_ServiceApi.Controllers
{
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }





    }
}
