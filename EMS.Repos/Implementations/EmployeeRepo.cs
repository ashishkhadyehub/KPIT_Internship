using EMS.Models;
using EMS.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Repos.Implementations
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        //get leave applications by comparing employee id
        public IEnumerable<LeaveApplication> GetApplications(int id)
        {
            return _context.LeaveApplications.Where(x => x.EmployeeId == id).ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }

        public Employee GetUserInfo(string email, string password)
        {
            var user = _context.Employees.FirstOrDefault(x => x.Email == email && x.Password == password);
            return user;
        }

        public void RegisterEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void SubmitApplication(LeaveApplication application)
        {
            _context.LeaveApplications.Add(application);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }
    }
}
