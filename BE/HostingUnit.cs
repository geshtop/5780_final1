using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{
    [Serializable()]
    public class HostingUnit
    {
        public int stSerialKey { get; set; }
        public int OwnerId { get; set; }
        [XmlIgnore]
        public Host Owner
        {
            get
            {
                return null;
            }
        }
         [XmlIgnore]
        public Enums.HosignUnitStatus Status { get; set; }
         [XmlIgnore]
        public Enums.HostingUnitType Type { get; set; }
         [XmlIgnore]
        public Enums.HostingUnitArea Area { get; set; }
         [XmlIgnore]
        public string StrArea
        {
            get
            {
                string t = "";
                switch (Area)
                {
                    case Enums.HostingUnitArea.All:
                        t = "הכל";
                        break;
                    case Enums.HostingUnitArea.North:
                        t = "צפון";
                        break;
                    case Enums.HostingUnitArea.South:
                        t = "דרום";
                        break;
                    case Enums.HostingUnitArea.Center:
                        t = "מרכז";
                        break;
                    case Enums.HostingUnitArea.Jerusalem:
                        t = "ירושלים";
                        break;
                    default:
                        break;
                }
                return t;
            }
        }
        [XmlIgnore]
        public string StrType
        {
            get
            {
                string t = "";
                switch (Type)
                {
                    case Enums.HostingUnitType.All:
                        t = "הכל";
                        break;
                    case Enums.HostingUnitType.Zimmer:
                        t = " צימר";
                        break;
                    case Enums.HostingUnitType.Hotel:
                        t = "מלון";
                        break;
                    case Enums.HostingUnitType.Camping:
                        t = "קמפינג";
                        break;
                    default:
                        break;
                }
                return t;
            }
        }

        public int TypeId
        {
            get
            {
                return (int)Type;
            }
            set
            {
                Type = ( Enums.HostingUnitType)value;
            }
        }

        public int AreaId
        {
            get
            {
                return (int)Area;
            }
            set
            {
                Area = (Enums.HostingUnitArea)value;
            }
        }
        public int StatusId
        {
            get
            {
                return (int)Status;
            }
            set
            {
                Status = (Enums.HosignUnitStatus)value;
            }
        }
        public string SubArea { get; set; }

        public bool Pool { get; set; }
        public bool Jacuzzi { get; set; }
        public bool Garden { get; set; }
        public bool ChildrensAttractions { get; set; }

        

        public int Adult { get; set; }
        public int Children { get; set; }
        public int Rooms { get; set; }
        public string HostingUnitName { get; set; }
       // [XmlIgnore]
       // public Diary DiaryState { get; set; }
        [XmlIgnore]
        public List<GalleryImageItem> Images { get; set; }
        [XmlIgnore]
        private List<GalleryImageItem> _TempImages;
        [XmlIgnore]
        public List<GalleryImageItem> TempImages
        {
            get
            {
                if (_TempImages == null)
                {
                    _TempImages = Images.ToList();
                }
                return _TempImages;

            }
            set
            {
                _TempImages = value;
            }
        }

        [XmlIgnore]
        public List<FullDays> Days { get; set; }
        public override string ToString()
        {
            return   HostingUnitName + ", " + stSerialKey + "\n" ;
        }

        public HostingUnit()
        {
            //DiaryState = new Diary();
            Images = new List<GalleryImageItem>();
            Days = new List<FullDays>();
        }
    }

    
}
