using Microsoft.AspNetCore.Mvc;
using AdventureWorks.Models;
using AdventureWorks.Business;

namespace AdventureWorks.Controllers
{
    public class SiteLayoutController : Controller
    {
        private readonly CategoryManager _categoryManager;

        public SiteLayoutController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public IActionResult HeaderLayout()
        {
            SiteLayoutModel header = new SiteLayoutModel();           
            return View(header);
        }

        public async Task<IActionResult> FooterLayout()
        {
            SiteLayoutModel footer = new SiteLayoutModel();
            footer.ProductCategories = await _categoryManager.GetMainCategoriesAsync();
            return View(footer);
        }

        public async Task<IActionResult> ContentLayout()
        {
            SiteLayoutModel header = new SiteLayoutModel();
            header.ProductCategories = await _categoryManager.GetMainCategoriesAsync();
            return View(header);
        }
    }
}