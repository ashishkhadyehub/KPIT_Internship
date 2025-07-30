using EMS.Models;
using EMS.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EMS.UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IDeptRepo _deptRepo;
        private readonly IBranchRepo _branchRepo;
        private readonly IAdminRepo _adminRepo;

        public AdminController(IDeptRepo deptRepo, IBranchRepo branchRepo, IAdminRepo adminRepo)
        {
            _deptRepo = deptRepo;
            _branchRepo = branchRepo;
            _adminRepo = adminRepo;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            if (admin.UserName == "admin" && admin.Password == "admin")
            {
                
                HttpContext.Session.SetString("Admin", "True");
                return RedirectToAction("BranchList");
            }
            else
            {
                ViewData["Message"] = "Invalid Login";
                return View();
            }

        }

        public IActionResult Index()
        {
            var employees = _adminRepo.GetAll();
            return View(employees);
        }

        public IActionResult ApplicationList()
        {

            var applications = _adminRepo.GetAllApplications();

            return View(applications);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var app = _adminRepo.GetById(id);


            return View(app);
        }

        [HttpPost]
        public IActionResult ApproveApp(LeaveApplication application)
        {
            var app = new LeaveApplication
            {
                Id = application.Id,


            };
            _adminRepo.UpdateApplication(app.Id,"Approved");
            return RedirectToAction("ApplicationList");

        }

        [HttpPost]
        public IActionResult RejectApp(LeaveApplication application)
        {
            var app = new LeaveApplication
            {
                Id = application.Id,


            };
            _adminRepo.UpdateApplication(app.Id, "Rajected");
            return RedirectToAction("ApplicationList");
        }

        [HttpGet]
        public IActionResult Logout()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult BranchList()
        {
            var branches = _branchRepo.GetAll();
            return View(branches);
        }

        [HttpGet]
        public IActionResult CreateBranch()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateBranch(Branch branch)
        {

            _branchRepo.Save(branch);
            TempData["Message"] = "True";
            return RedirectToAction("BranchList");
        }

        [HttpGet]
        public IActionResult EditBranch(int id)
        {
            var branch = _branchRepo.GetById(id);

            return View(branch);
        }

        [HttpPost]
        public async Task<IActionResult> EditBranch(Branch branch)
        {
            _branchRepo.Edit(branch);
            return RedirectToAction("BranchList");


        }

        public IActionResult DeleteBranch(Branch branch)
        {

            _branchRepo.RemoveData(branch);
            return RedirectToAction("BranchList");
        }

        public IActionResult DeptList()
        {
            var departments = _deptRepo.GetAll();

            return View(departments);
        }

        [HttpGet]
        public async Task<IActionResult> CreateDept()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateDept(Department department)
        {
            _deptRepo.Save(department);

            return RedirectToAction("DeptList");


        }

        [HttpGet]
        public IActionResult EditDept(int id)
        {
            var dept = _deptRepo.GetById(id);

            return View(dept);
        }

        [HttpPost]
        public async Task<IActionResult> EditDept(Department department)
        {
            _deptRepo.Edit(department);
            return RedirectToAction("DeptList");


        }

        public async Task<IActionResult> DeleteDept(Department department)
        {
            _deptRepo.RemoveData(department);
            return RedirectToAction("DeptList");
        }


    }
}
