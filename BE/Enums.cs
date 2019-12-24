using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public static class Enums
    {
        public enum HostingUnitType
        {
            Zimmer =0,
            Hotel =1,
            Camping =2,
        }
        public enum HostingUnitArea
        {
            All =0,
            North =1,
            South =2,
            Center =3,
            Jerusalem =4,
        }
        public enum DataSourseType
        {
            List,
            XML
        }
        public enum PoolType
        {
            All =0,
            Necessary =1,
            Possible =2 ,
            Not_interested =3
        }
        public enum JacuzziType
        {
            All = 0,
            Necessary = 1,
            Possible = 2,
            Not_interested = 3
        }
        public enum GardenType
        {
            All = 0,
            Necessary = 1,
            Possible = 2,
            Not_interested = 3
        }
        public enum ChildrensAttractionsType
        {
            All = 0,
            Necessary = 1,
            Possible = 2,
            Not_interested = 3
        }
        public enum OrderStatus
        {
            Not_treated,
            Mailed,
            Closes_out_of_unresponsiveness,
            Closes_in_response,
        }
        public enum GuestRequestStatus
        {
            Active,
            closed_on_site,
            Expired,
        }

        public enum HosignUnitStatus  {
            Active,
            closed_on_site,
            Expired,
        }

        public enum GuestRequesteCreateStatus
        {
            Done,
            ErrorDates,
            NoHosting,


        }
    }
}
