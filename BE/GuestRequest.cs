using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        private int GuestRequestsKey { get; set; }
        private string PrivateName { get; set; }
        private string FamilyName { get; set; }
        private string MailAddress { get; set; }
        private string Status { get; set; }
        private DateTime RegistrationDate { get; set; }
        private DateTime EntryDate { get; set; }
        private DateTime ReleaseDate { get; set; }
        private string Area { get; set; }
        private string SubArea { get; set; }
        private string Type { get; set; }
        private int Adult { get; set; }
        private int Children { get; set; }
        private string Pool { get; set; }
        private string Jacuzzi { get; set; }
        private string Garden { get; set; }
        private string ChildrensAttractions { get; set; }
        public override string ToString()
        {
            return (GuestRequestsKey + ":\n" + PrivateName + " " + FamilyName + "\n" + MailAddress + "\n" + Status 
                + "\nRegistration Date: " + RegistrationDate + "\nEntry Date: " + EntryDate + "\nRelease Date: " + ReleaseDate 
                + "\n" + SubArea + ", " + Area + "\nNum Of Adults: " + Adult + "\nNum Of Children: " + Children
                + "\nPool: " + Pool + "\nJacuzzi: " + Jacuzzi + "\nGarden: " + Garden + "\nChildrensAttractions: " + ChildrensAttractions);
        }
    }
}
