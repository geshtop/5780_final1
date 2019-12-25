using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Branches
    {
        public static List<BankBranch> getBranches()
        {
            return DS.Branches.getAllBrancehs();
        }
    }
}
