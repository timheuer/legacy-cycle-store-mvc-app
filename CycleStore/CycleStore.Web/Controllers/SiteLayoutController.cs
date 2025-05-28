using Microsoft.AspNetCore.Mvc;

namespace CycleStore.Web.Controllers
{
    public class SiteLayoutController : Controller
    {
        public IActionResult HeaderLayout()
        {
            return PartialView();
        }

        public IActionResult ContentLayout()
        {
            return PartialView();
        }
    }
}
