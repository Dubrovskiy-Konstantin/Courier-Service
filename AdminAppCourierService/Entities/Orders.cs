using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminAppCourierService.Entities
{
    class Orders
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public float TotalDistance { get; set; }
        public float Cost { get; set; }
        public bool Express { get; set; }
        public int Status { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string Date { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
