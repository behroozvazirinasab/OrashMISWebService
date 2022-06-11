using Microsoft.AspNetCore.Mvc;

namespace OMISWS_ServiceApi.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
