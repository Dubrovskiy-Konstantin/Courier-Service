using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminAppCourierService.Entities
{
    class Nodes
    {
        public int Id { get; set; }
        public int IdOrder { get; set; }
        public int IdCar { get; set; }
        public int IdMover { get; set; }
        public int IdDriver { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
