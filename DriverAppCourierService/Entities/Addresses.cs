using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverAppCourierService.Entities
{
    class Addresses
    {
        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Address}";
        }
    }
}
