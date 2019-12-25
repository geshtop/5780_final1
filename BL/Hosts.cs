using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Hosts
    {
        public static List<Host> getHosts()
        {
            return DS.Hosts.getHosts();
        }

    }
}
