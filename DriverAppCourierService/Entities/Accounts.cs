using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverAppCourierService.Entities
{
    class Accounts
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdDriver { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
