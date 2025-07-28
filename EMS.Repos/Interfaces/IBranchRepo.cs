using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Repos.Interfaces
{
    public interface IBranchRepo
    {
        IEnumerable<Branch> GetAll();

        Branch GetById(int id);

        void Save(Branch branch);

        void Edit(Branch branch);

        void RemoveData(Branch branch);
    }
}
