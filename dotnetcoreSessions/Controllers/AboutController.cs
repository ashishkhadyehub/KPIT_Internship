using Microsoft.AspNetCore.Mvc;

namespace dotnetcoreSessions.Controllers
{
    public class AboutController : Controller
    {

        //Action Method
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            return View();
        }
    }
}
