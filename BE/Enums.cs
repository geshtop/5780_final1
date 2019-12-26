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
            Not_interested =2
        }
        public enum JacuzziType
        {
            All = 0,
            Necessary = 1,
            Not_interested = 2
        }
        public enum GardenType
        {
            All = 0,
            Necessary = 1,
            Not_interested = 2
        }
        public enum ChildrensAttractionsType
        {
            All = 0,
            Necessary = 1,
            Not_interested = 2
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
            Opened = 0, // הבקשה נקלטה במערכת
            InProccess = 1, // נשלחה הצעה ללקוח  במייל
            ActiveAndClose = 2,  // נסגרה יחידת אירוח למשתמש
            Closed=3, // נסגר באמצעות המערכת
            Expired = 4, // לא מומשה ועבר הזמן
        }

        public enum HosignUnitStatus  {
            Active,
            DeActive,
            Paused
        }


        public enum HostValidationStatus
        {
            Success = 0, //נמצא תקין
            MissingFields = 1, //חסרים שדות
            DuplicateId=2, //תעודת הזהות קיימת כבר במערכת
            WrongFields =3, // שדות לא תקינים דוגמא תעודת זהות עם מעט תווים
            HasActiveHostingUnits =4, //לא ניתן למחוק בגלל שיש יחידות אירוח שעדיין פעילות
            Faild=5 //שגיאת מסד
        }

        public enum GuestRequesteCreateStatus
        {
            Done,
            ErrorDates,
            NoHosting,
        }
    }
}
