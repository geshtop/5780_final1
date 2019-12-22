using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        private int HostingUnitKey { get; set; }
        private int GuestRequestKey { get; set; }
        private int OrderKey { get; set; }
        private string Status { get; set; }
        private DateTime CreateDate { get; set; }
        private DateTime OrderDate { get; set; }
        public override string ToString()
        {
            return (HostingUnitKey + "\n" + GuestRequestKey + "\n" + OrderKey
                + "\n" + Status + "\nCreateDate: " + CreateDate + "\nOrderKey: " + OrderKey);
        }
    }
}
