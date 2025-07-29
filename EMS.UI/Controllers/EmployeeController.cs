using EMS.Models;
using EMS.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMS.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IBranchRepo _branchRepo;
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IDeptRepo _deptRepo;

        public EmployeeController(IBranchRepo branchRepo, IEmployeeRepo employeeRepo, IDeptRepo deptRepo)
        {
            _branchRepo = branchRepo;
            _employeeRepo = employeeRepo;
            _deptRepo = deptRepo;
        }

        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            var branchlist = _branchRepo.GetAll();
            ViewBag.BranchList = new SelectList(branchlist, "BranchName", "BranchName");

            var deptlist = _deptRepo.GetAll();
            ViewBag.DeptList = new SelectList(deptlist, "Name", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(Employee employee)
        {

            _employeeRepo.RegisterEmployee(employee);
            TempData["Message"] = "You can login now";
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(EmployeeLogin user)
        {
            var userInfo = _employeeRepo.GetUserInfo(user.Email, user.Password);
            if (userInfo != null)
            {

                HttpContext.Session.SetInt32("userId", userInfo.Id);
                HttpContext.Session.SetString("userName", userInfo.Name);
                return RedirectToAction("Profile", "Employee");
            }
            else
            {
                ViewData["Message"] = "Invalid Login";
                return View();
            }

        }

        [HttpGet]
        public IActionResult Logout()
        {
            
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Profile()
        {

            if (HttpContext.Session.GetInt32("userId") != null)
            {
                var branchlist = _branchRepo.GetAll();
                ViewBag.BranchList = new SelectList(branchlist, "BranchName", "BranchName");

                var deptlist = _deptRepo.GetAll();
                ViewBag.DeptList = new SelectList(deptlist, "Name", "Name");


                var profile = _employeeRepo.GetById((int)HttpContext.Session.GetInt32("userId"));

                return View(profile);
            }
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Profile(Employee employee)
        {
            _employeeRepo.UpdateEmployee(employee);
            return RedirectToAction("Home");
        }

        [HttpGet]
        public IActionResult Application()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Application(LeaveApplication leaveApplication)
        {
            leaveApplication.EmployeeId = (int)HttpContext.Session.GetInt32("userId");
            leaveApplication.Status = "Submitted";
            _employeeRepo.SubmitApplication(leaveApplication);
            return RedirectToAction("AppList");
        }

        public IActionResult AppList()
        {
            var vm = new List<LeaveApplication>();
            var apps = _employeeRepo.GetApplications((int)HttpContext.Session.GetInt32("userId"));

            return View(apps);
        }
    }
}
