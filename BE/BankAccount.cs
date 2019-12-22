using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BankAccount
    {
        private int BankNumber { get; set; }
        private string BankName { get; set; }
        private int BranchNumber { get; set; }
        private string BranchAddress { get; set; }
        private string BranchCity { get; set; }
        private int BankAccountNumber { get; set; }
        public override string ToString()
        {
            return (BankAccountNumber + ", " + BankName + " - " + BankNumber + ", " + BranchNumber
                + "\n" + BranchAddress + ", " + BranchCity);
        }
    }
}
