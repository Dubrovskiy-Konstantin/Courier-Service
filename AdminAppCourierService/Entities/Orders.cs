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
        public float TotalDistance { get; set; }
        public float Cost { get; set; }
        public bool Payed { get; set; }
        public int Status { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }
        public int ExpectedNumOfMovers { get; set; }
        public int IdPointFrom { get; set; }
        public int IdPointTo { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public string Date { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
