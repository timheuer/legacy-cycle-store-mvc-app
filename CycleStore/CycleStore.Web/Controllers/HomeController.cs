using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CycleStore.Web.Models;
using CycleStore.Web.Data;

namespace CycleStore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CycleStoreContext _context;

        public HomeController(ILogger<HomeController> logger, CycleStoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Default()
        {
            ViewBag.BodyClass = "homepage";
            return View();
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(Default));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
