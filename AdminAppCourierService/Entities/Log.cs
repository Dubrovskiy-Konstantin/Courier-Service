using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminAppCourierService.Entities
{
    class Log
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string EndDate { get; set; }
        public int ArchiveId { get; set; }
        public int Income { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}
