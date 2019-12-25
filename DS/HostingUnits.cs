using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class HostingUnits
    {
        public static List<BE.HostingUnit> getHostingUnits()
        {
            List<BE.HostingUnit> hostingUnits = new List<BE.HostingUnit>();
            hostingUnits.Add(new HostingUnit() { });
            hostingUnits.Add(new HostingUnit() { });
            hostingUnits.Add(new HostingUnit() { });
            hostingUnits.Add(new HostingUnit() { });
            return hostingUnits;
        }
    }
}
