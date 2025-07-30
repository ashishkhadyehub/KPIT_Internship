using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Repos.Interfaces
{
    public interface IAdminRepo
    {
       
        IEnumerable<Employee> GetAll();

        IEnumerable<LeaveApplication> GetAllApplications();

        void UpdateApplication(int id, string status);

        LeaveApplication GetById(int id);
    }
}
