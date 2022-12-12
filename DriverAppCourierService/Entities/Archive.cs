using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverAppCourierService.Entities
{
    class Archive
    {
        public int Id { get; set; }
        public string DriverName { get; set; }
        public string CarNumber { get; set; }
        public string OrderPoints { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
