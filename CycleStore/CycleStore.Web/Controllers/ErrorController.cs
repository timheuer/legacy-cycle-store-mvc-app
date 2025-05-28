using Microsoft.AspNetCore.Mvc;

namespace CycleStore.Web.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Default()
        {
            return View();
        }

        [Route("Error")]
        public IActionResult Index()
        {
            return View("Default");
        }
    }
}
