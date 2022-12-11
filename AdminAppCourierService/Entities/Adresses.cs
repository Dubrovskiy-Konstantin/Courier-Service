using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminAppCourierService.Entities
{
    class Adresses
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Address}";
        }
    }
}
