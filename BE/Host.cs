using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{
    [Serializable()]
    public class Host
    {
        public Host()
        {
            RelatedHostingUnit = new List<HostingUnit>();
        }
        public int Id { get; set; }
        public string HostKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhonePre { get; set; }
        public string PhoneExt { get; set; }
        public string MailAddress { get; set; }
        public string Password { get; set; }
        public int Discount { get; set; }
        [XmlIgnore] //תתעלם מזה ואל תכניס לXML
        public string Phone
        {
            get
            {
                return PhonePre + "-" + PhoneExt;
            }
        }
        [XmlIgnore]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        [XmlIgnore]
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
        [XmlIgnore]
        public List<HostingUnit> RelatedHostingUnit { get; set; }
        [XmlIgnore]
        public int NumHostingUnit
        {
            get
            {
                return RelatedHostingUnit.Count;
            }
        }
        
        public override string ToString()
        {
            return (HostKey + ", " + FirstName + " " + LastName + "\n" + PhonePre + PhoneExt + ", " + MailAddress
                + "\n" + BankAccount.ToString() + "\nCollectionClearance: " + CollectionClearance);
        }
    }


  
 
}
