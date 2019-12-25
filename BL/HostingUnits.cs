using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class HostingUnits
    {
        public static List<HostingUnit> getHostingUnits()
        {
            return DS.HostingUnits.getHostingUnits();
        }
    }
}
