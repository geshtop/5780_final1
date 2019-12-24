using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        public int HostKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string PhonePre { get; set; }
        public string PhoneExt { get; set; }
        public string MailAddress { get; set; }
        public BankBranch Branc { get; set; }
        public string BankAccount { get; set; }
        public bool CollectionClearance { get; set; }
        public override string ToString()
        {
            return (HostKey + ", " + PrivateName + " " + FamilyName + "\n" + PhonePre + PhoneExt + ", " + MailAddress
                + "\n" + BankAccount.ToString() + "\nCollectionClearance: " + CollectionClearance);
        }
    }
}
