using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        private int HostingUnitKey { get; set; }
        private Host Owner { get; set; }
        private string HostingUnitName { get; set; }
        private bool[,] Diary { get; set; }
        public override string ToString()
        {
            return (Owner + "\n" + HostingUnitName + ", " + HostingUnitKey + "\n" + Diary);
        }
    }
}
