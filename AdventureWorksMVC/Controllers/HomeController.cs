using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Default()
        {
            ViewBag.BodyClass = "homepage";
            return View();
        }

        public IActionResult Index()
        {
            return RedirectToAction("Default");
        }
    }
}
