using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        public int stSerialKey { get; set; }
        private int HostingUnitKey
        {
            get
            {
                return stSerialKey;
            }
        }
        public Host Owner { get; set; }
        public Enums.HosignUnitStatus Status { get; set; }
        public string HostingUnitName { get; set; }
        public Diary DiaryState { get; set; }
        public override string ToString()
        {
            return Owner.ToString() + "\n" + HostingUnitName + ", " + HostingUnitKey + "\n" + DiaryState;
        }

        public HostingUnit()
        {
            this.stSerialKey = Configuration.HostingUnitKey;
            Configuration.HostingUnitKey++;

        }
    }
}
