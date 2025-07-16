using System.Diagnostics;
using dotnetcoreSessions.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcoreSessions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //int a = 90;
            //return View(a);

            //string name = "John Doe";
            //return View("Index",name);

            //Students student = new Students();
            //student.Id = 1;
            //student.Name = "John Doe";
            //student.City = "New York";
            //return View(student);

            List<Students> students = new List<Students>();
            students.Add(new Students 
            { 
              Id=1,
              Name="Test",
              City="Kolhapur" 
            });
            students.Add(new Students 
            { 
              Id=2,
              Name="ABC",
              City="PUNE" 
            });
            students.Add(new Students 
            { 
              Id=3,
              Name="PQR",
              City="Mumbai" 
            });
            students.Add(new Students 
            { 
              Id=4,
              Name="Hello",
              City="Delhi" 
            });

            return View(students);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
