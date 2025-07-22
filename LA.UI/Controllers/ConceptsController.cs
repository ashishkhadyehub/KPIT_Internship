using Microsoft.AspNetCore.Mvc;

namespace LA.UI.Controllers
{
    public class ConceptsController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Message = "Testing Viewbag";
            //ViewData["Message"] = "Testing ViewData";
            TempData["Message"] = "Testing Tempdata";
            return View();
        }

        public IActionResult NextPage()
        {
            return View();
        }
    }
}
