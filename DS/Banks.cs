using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DS
{
    public class Banks
    {

        public static List<Bank> getAllBanks()
        {

            List<Bank> list = new List<Bank>();

            list.Add(new Bank() { BankName = "הפועלים", BankCode = 12 });
            list.Add(new Bank() { BankName = "לאומי", BankCode = 10 });
            list.Add(new Bank() { BankName = "דיסקונט", BankCode = 11 });

            // Add all missing banks
            return list;
        }
    }
}
