using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverAppCourierService.Entities
{
    class Orders
    {
        public int Id { get; set; }
        public double TotalDistance { get; set; }
        public double Cost { get; set; }
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
            return $"Order: {ClientName}, Phone: {ClientPhone}.\n" +
                $"From {SqlWorkerDriverApp.GetAddressById(IdPointFrom)} to {SqlWorkerDriverApp.GetAddressById(IdPointTo)}\n" +
                $"Time: {TimeFrom} - {TimeTo} {Date}";
        }
    }
}
