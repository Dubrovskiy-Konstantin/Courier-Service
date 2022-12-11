using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminAppCourierService.Entities
{
    class Cars
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string RegistryNumber { get; set; }
        public int IssueYear { get; set; }
        public float Mileage { get; set; }
        public string LastMaintenance { get; set; }
        public bool IsFree { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
