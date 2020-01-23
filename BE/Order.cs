using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{
    public class Order
    {
        public int HostingUnitKey { get; set; }
        public int GuestRequestKey { get; set; }
        public int OrderKey { get; set; }
        [XmlIgnore]
        public Enums.OrderStatus Status { get; set; }
        public int StatusId
        {
            get
            {
                return (int)Status;
            }
            set
            {
                Status = (Enums.OrderStatus)value;
            }
        }
        public DateTime CreateDate { get; set; }
        public DateTime OrderDate { get; set; }
        public override string ToString()
        {
            return (HostingUnitKey + "\n" + GuestRequestKey + "\n" + OrderKey
                + "\n" + Status + "\nCreateDate: " + CreateDate + "\nOrderKey: " + OrderKey);
        }
    }
}
