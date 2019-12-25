using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        public int GuestRequestsKey { get; set; }
        public string PrivateName { get; set; }
        public string FamilyName { get; set; }
        public string MailAddress { get; set; }
        public string PhonePre { get; set; }
        public string PhoneExt { get; set; }
        public Enums.GuestRequestStatus Status { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Enums.HostingUnitArea Area { get; set; }
        public string SubArea { get; set; }
        public Enums.HostingUnitType Type { get; set; }
        public int Adult { get; set; }
        public int Children { get; set; }
        public int Rooms { get; set; }
        public Enums.PoolType Pool { get; set; }
        public Enums.JacuzziType Jacuzzi { get; set; }
        public Enums.GardenType Garden { get; set; }
        public Enums.ChildrensAttractionsType ChildrensAttractions { get; set; }
        public override string ToString()
        {
            return (GuestRequestsKey + ":\n" + PrivateName + " " + FamilyName + "\n" + MailAddress + "\n" + Status 
                + "\nRegistration Date: " + RegistrationDate + "\nEntry Date: " + EntryDate + "\nRelease Date: " + ReleaseDate 
                + "\n" + SubArea + ", " + Area + "\nNum Of Adults: " + Adult + "\nNum Of Children: " + Children
                + "\nPool: " + Pool + "\nJacuzzi: " + Jacuzzi + "\nGarden: " + Garden + "\nChildrensAttractions: " + ChildrensAttractions);
        }
    }
}
