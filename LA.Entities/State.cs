using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Entities
{
    public class State
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        //Navigation property to Districts

        public Country? Country { get; set; }
        public ICollection<District> Districts { get; set; } = new HashSet<District>();
    }
}
