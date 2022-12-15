using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminAppCourierService.Entities
{
    class Details
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public string Unit { get; set; }
        public string UnitDescription { get; set; }
        public int UnitAmount { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
