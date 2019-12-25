using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Banks
    {
        public static List<Bank> getBanks()
        {
            return DS.Banks.getAllBanks();
        }
    }
}
