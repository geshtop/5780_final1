using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class HostingUnits
    {
        public static List<BE.HostingUnit> getHostingUnits()
        {
            List<BE.HostingUnit> hostingUnits = new List<BE.HostingUnit>();
            var hosting1 = new HostingUnit()
            {
                OwnerId = 1,
                HostingUnitName = "צימר לכל דורש",
                Status = Enums.HosignUnitStatus.Active,
                Type = Enums.HostingUnitType.Zimmer,
                Children = 7,
                Adult = 3,
                Rooms = 3,
                Pool = true,
                Jacuzzi = false,
                Garden = false,
                ChildrensAttractions = false,
                Area = Enums.HostingUnitArea.Center,
                SubArea = "תל אביב", 
            };
            hosting1.Images.Add("https://pic.rrr.co.il/images/oazis/2.jpg");
            hosting1.Images.Add("https://pic.rrr.co.il/images/oazis/1.jpg");



            var hosting2 = new HostingUnit()
            {
                OwnerId = 2,
                HostingUnitName = "צימר האיילות",
                Status = Enums.HosignUnitStatus.Active,
                Type = Enums.HostingUnitType.Zimmer,
                Children = 1,
                Adult = 3,
                Rooms = 3,
                Pool = true,
                Jacuzzi = true,
                Garden = true,
                ChildrensAttractions = true,
                Area = Enums.HostingUnitArea.South,
                SubArea = "אילת",
            };
            hosting2.Images.Add("https://pic.rrr.co.il/images/oazis/3.jpg");
            hosting2.Images.Add("https://pic.rrr.co.il/images/oazis/5.jpg");


            var hosting4 = new HostingUnit()
            {
                OwnerId = 1,
                HostingUnitName = "קמפ בני הישיבות",
                Status = Enums.HosignUnitStatus.Active,
                Type = Enums.HostingUnitType.Camping,
                Children = 7,
                Adult = 3,
                Rooms = 3,
                Pool = false,
                Jacuzzi = true,
                Garden = true,
                ChildrensAttractions = true,
                Area = Enums.HostingUnitArea.North,
                SubArea = "טבריה",
            };
            hosting4.Images.Add("https://pic.rrr.co.il/images/oazis/4.jpg");
            hosting4.Images.Add("https://pic.rrr.co.il/images/oazis/6.jpg");



            var hosting3 = new HostingUnit()
            {
                OwnerId = 2,
                HostingUnitName = "מלון הכוכבים",
                Status = Enums.HosignUnitStatus.Active,
                Type = Enums.HostingUnitType.Hotel,
                Children = 1,
                Adult = 3,
                Rooms = 1,
                Pool = false,
                Jacuzzi = true,
                Garden = true,
                ChildrensAttractions = false,
                Area = Enums.HostingUnitArea.Jerusalem,
                SubArea = "ירושלים",
            };
            hosting3.Images.Add("https://pic.rrr.co.il/images/oazis/7.jpg");
            hosting3.Images.Add("https://pic.rrr.co.il/images/oazis/8.jpg");


            var hosting5 = new HostingUnit()
            {
                OwnerId = 3,
                HostingUnitName = "מלון יורלוק",
                Status = Enums.HosignUnitStatus.Active,
                Type = Enums.HostingUnitType.Hotel,
                Children = 7,
                Adult = 3,
                Rooms = 3,
                Pool = true,
                Jacuzzi = false,
                Garden = false,
                ChildrensAttractions = false,
                Area = Enums.HostingUnitArea.Center,
                SubArea = "תל אביב",
            };
            hosting5.Images.Add("https://pic.rrr.co.il/images/oazis/9.jpg");
            hosting5.Images.Add("https://pic.rrr.co.il/images/oazis/10.jpg");



            var hosting6 = new HostingUnit()
            {
                OwnerId = 4,
                HostingUnitName = "צימר ציון גבר",
                Status = Enums.HosignUnitStatus.Active,
                Type = Enums.HostingUnitType.Zimmer,
                Children = 1,
                Adult = 3,
                Rooms = 3,
                Pool = true,
                Jacuzzi = true,
                Garden = true,
                ChildrensAttractions = true,
                Area = Enums.HostingUnitArea.South,
                SubArea = "אילת",
            };
            hosting6.Images.Add("https://pic.rrr.co.il/images/oazis/11.jpg");
            hosting6.Images.Add("https://pic.rrr.co.il/images/oazis/12.jpg");


            var hosting7 = new HostingUnit()
            {
                OwnerId = 4,
                HostingUnitName = "קמפ בננות",
                Status = Enums.HosignUnitStatus.Active,
                Type = Enums.HostingUnitType.Camping,
                Children = 7,
                Adult = 3,
                Rooms = 3,
                Pool = false,
                Jacuzzi = true,
                Garden = true,
                ChildrensAttractions = true,
                Area = Enums.HostingUnitArea.North,
                SubArea = "טבריה",
            };
          
            hosting7.Images.Add("https://pic.rrr.co.il/images/oazis/13.jpg");
            hosting7.Images.Add("https://pic.rrr.co.il/images/oazis/14.jpg");


            var hosting8 = new HostingUnit()
            {
                OwnerId = 4,
                HostingUnitName = "מלון כפיר",
                Status = Enums.HosignUnitStatus.Active,
                Type = Enums.HostingUnitType.Hotel,
                Children = 1,
                Adult = 3,
                Rooms = 1,
                Pool = false,
                Jacuzzi = true,
                Garden = true,
                ChildrensAttractions = false,
                Area = Enums.HostingUnitArea.Jerusalem,
                SubArea = "ירושלים",
            };
            hosting8.Images.Add("https://pic.rrr.co.il/images/oazis/15.jpg");
            hosting8.Images.Add("https://pic.rrr.co.il/images/oazis/16.jpg");
            hostingUnits.Add(hosting1);
            hostingUnits.Add(hosting2);
            hostingUnits.Add(hosting3);
            hostingUnits.Add(hosting4);
            hostingUnits.Add(hosting5);
            hostingUnits.Add(hosting6);
            hostingUnits.Add(hosting7);
            hostingUnits.Add(hosting8);
          
            return hostingUnits;
        }
    }
}
