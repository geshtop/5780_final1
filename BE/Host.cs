using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Host
    {
        private int HostKey { get; set; }
        private string PrivateName { get; set; }
        private string FamilyName { get; set; }
        private long FhoneNumber { get; set; }
        private string MailAddress { get; set; }
        private BankAccount BankAccount { get; set; }
        private string CollectionClearance { get; set; }
        public override string ToString()
        {
            return (HostKey + ", " + PrivateName + " " + FamilyName + "\n" + FhoneNumber + ", " + MailAddress
                + "\n" + BankAccount.ToString() + "\nCollectionClearance: " + CollectionClearance);
        }
    }
}
