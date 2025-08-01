﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.Entities
{
    public class District
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int StateId { get; set; }

        // Navigation property to State
        public State? State { get; set; }
    }
}
