using LA.Entities;
using LA.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Repositories.Implementations
{
    public class DistrictRepo : IDistrictRepo
    {
        private readonly ApplicationDbContext _context;

        public DistrictRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Edit(District district)
        {
            _context.Districts.Update(district);
            _context.SaveChanges();
        }

        public IEnumerable<District> GetAll()
        {
            return _context.Districts.ToList();
        }

        public District GetById(int id)
        {
            return _context.Districts.Find(id);
        }

        public void RemoveData(District district)
        {
           _context.Districts.Remove(district);
            _context.SaveChanges();
        }

        public void Save(District district)
        {
            _context.Districts.Add(district);
            _context.SaveChanges();
        }
    }
}
