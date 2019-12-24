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
            Zimmer,
            Hotel,
            Camping,
        }
        public enum HostingUnitArea
        {
            All,
            North,
            South,
            Center,
            Jerusalem,
        }
        public enum DataSourseType
        {
            List,
            XML
        }
        public enum PoolType
        {
            Necessary,
            Possible,
            Not_interested
        }
        public enum JacuzziType
        {
            Necessary,
            Possible,
            Not_interested,
        }
        public enum GardenType
        {
            Necessary,
            Possible,
            Not_interested,
        }
        public enum ChildrensAttractionsType
        {
            Necessary,
            Possible,
            Not_interested,
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
    }
}
