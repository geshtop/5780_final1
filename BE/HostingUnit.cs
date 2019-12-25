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
        public int OwnerId { get; set; }
        public Host Owner
        {
            get
            {
                return null;
            }
        }
        public Enums.HosignUnitStatus Status { get; set; }
        public Enums.HostingUnitType Type { get; set; }
        public Enums.HostingUnitArea Area { get; set; }
        public string SubArea { get; set; }

        public bool Pool { get; set; }
        public bool Jacuzzi { get; set; }
        public bool Garden { get; set; }
        public bool ChildrensAttractions { get; set; }

        public int Adult { get; set; }
        public int Children { get; set; }
        public int Rooms { get; set; }
        public string HostingUnitName { get; set; }
        public Diary DiaryState { get; set; }
        public List<string> Images { get; set; }
        public override string ToString()
        {
            return Owner.ToString() + "\n" + HostingUnitName + ", " + HostingUnitKey + "\n" + DiaryState;
        }

        public HostingUnit()
        {
            DiaryState = new Diary();
            Images = new List<string>();
            this.stSerialKey = Configuration.HostingUnitKey;
            Configuration.HostingUnitKey++;

        }
    }
}
