﻿using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Repos.Interfaces
{
    public interface IDeptRepo
    {
        IEnumerable<Department> GetAll();

        Department GetById(int id);

        void Save(Department department);

        void Edit(Department department);

        void RemoveData(Department department);
    }
}
