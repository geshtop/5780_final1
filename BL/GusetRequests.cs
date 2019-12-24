using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class GusetRequests
    {
        public void AddGusetRequest(GuestRequest guestRequest, out Enums.GuestRequesteCreateStatus createStatus)
        {
            createStatus = Enums.GuestRequesteCreateStatus.NoHosting;
        }
    }
}
