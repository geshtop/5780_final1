using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Host
    {
        public int Id { get; set; }
        public long HostKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhonePre { get; set; }
        public string PhoneExt { get; set; }
        public string MailAddress { get; set; }
        public string Phone
        {
            get
            {
                return PhonePre + "-" + PhoneExt;
            }
        }
        public BankBranch Branch
        {
            get
            {
                return null;
            }
        }
        public int BankNumber { get; set; }
        public int BranchNumber { get; set; }
        public int BankAccount { get; set; }
        public bool CollectionClearance { get; set; }
        public override string ToString()
        {
            return (HostKey + ", " + FirstName + " " + LastName + "\n" + PhonePre + PhoneExt + ", " + MailAddress
                + "\n" + BankAccount.ToString() + "\nCollectionClearance: " + CollectionClearance);
        }
    }
}
