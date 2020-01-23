using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FullDays
    {
        public int Id { get; set; }
        public int HostingUnitId { get; set; }
        public DateTime Date { get; set; }
        public int OrderId { get; set; }
    }
}
