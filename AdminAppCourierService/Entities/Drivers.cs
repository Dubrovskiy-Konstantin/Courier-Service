﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminAppCourierService.Entities
{
    class Drivers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int CountOfOrder { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
