using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BL
{
    public class AppLogic
    {
        private Dal_imp dal { get; set; }
        public AppLogic()
        {
            dal = new Dal_imp();
        }


        #region Hosts

        public List<Host> GetAllHosts()
        {
            return dal.GetAllHosts();
        }
        public void DeleteHost(int Id)
        {

            dal.DeleteHost(Id);
        }

        public Host GetHostById(int Id)
        {
            return dal.GetHostById(Id);
        }

        public void UpdateHost(Host host, out Enums.HostValidationStatus status)
        {
            status = Enums.HostValidationStatus.Success;
            if (string.IsNullOrEmpty(host.FirstName) || (string.IsNullOrEmpty(host.LastName)) || string.IsNullOrEmpty(host.PhonePre) || string.IsNullOrEmpty(host.PhoneExt))
            {
                status = Enums.HostValidationStatus.MissingFields;
                return;
            }
            //בדיקה האם תעודת הזהות והטלפון זה ספרות
            long id = 0;

            long.TryParse(host.PhoneExt, out id);
            if (id == 0)
            {
                status = Enums.HostValidationStatus.WrongFields;
                return;
            }
            if (!string.IsNullOrEmpty(host.MailAddress))
            {
                //ואלידציה לכתובת המייל
                Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!regex.IsMatch(host.MailAddress))
                {
                    status = Enums.HostValidationStatus.WrongFields;
                    return;
                }
            }
            if (host.PhoneExt.Length < 7)
            {
                status = Enums.HostValidationStatus.WrongFields;
                return;
            }
            dal.UpdateHost(host);
        }

        public void AddHost(Host host, out Enums.HostValidationStatus status)
        {
            status = Enums.HostValidationStatus.Success;

            if (string.IsNullOrEmpty(host.FirstName) || string.IsNullOrEmpty(host.LastName) || string.IsNullOrEmpty(host.HostKey) || string.IsNullOrEmpty(host.PhonePre) || string.IsNullOrEmpty(host.PhoneExt))
            {
                status = Enums.HostValidationStatus.MissingFields;
                return;
            }
            if (host.HostKey.Length < 9)
            {
                status = Enums.HostValidationStatus.WrongFields;
                return;
            }

            var HostsWithSameIds = dal.GetAllHosts(c => c.HostKey == host.HostKey);
            if (HostsWithSameIds.Count > 0)
            {
                status = Enums.HostValidationStatus.DuplicateId;
                return;
            }
            //בדיקה האם תעודת הזהות והטלפון זה ספרות
            long id = 0;
            long.TryParse(host.HostKey, out id);
            if (id == 0)
            {
                status = Enums.HostValidationStatus.WrongFields;
                return;
            }
            long.TryParse(host.PhoneExt, out id);
            if (id == 0)
            {
                status = Enums.HostValidationStatus.WrongFields;
                return;
            }
            if (!string.IsNullOrEmpty(host.MailAddress))
            {
                //ואלידציה לכתובת המייל
                Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!regex.IsMatch(host.MailAddress))
                {
                    status = Enums.HostValidationStatus.WrongFields;
                    return;
                }
            }
            if (host.PhoneExt.Length < 7)
            {
                status = Enums.HostValidationStatus.WrongFields;
                return;
            }
            dal.AddHost(host);
        }
        #endregion


        #region HostingUnits


        public List<BE.HostingUnit> GetHostingUnits(Func<BE.HostingUnit, bool> predicate = null)
        {
            return dal.GetHostingUnits(predicate);
        }

        public HostingUnit GetHostingUnitById(int stSerialKey)
        {
            return dal.GetHostingUnitById(stSerialKey);
        }

        public void AddHostingUnit(BE.HostingUnit hostingUnit)
        {
            dal.AddHostingUnit(hostingUnit);
        }

        public void DeleteHostingUnit(BE.HostingUnit hostingUnit)
        {
            dal.DeleteHostingUnit(hostingUnit);
        }

        public void UpdatingHostingUnit(BE.HostingUnit hostingUnit, Enums.HosignUnitStatus status)
        {
            dal.UpdatingHostingUnit(hostingUnit, status);
        }



        #endregion


        #region Banks

        public List<Bank> GetBanksList()
        {
            return dal.GetBanksList();
        }

        #endregion


        #region Branch



        public List<BankBranch> GetBankBranches(Func<BankBranch, bool> predicate)
        {
            return dal.GetBankBranches(predicate);
        }

        public List<BankBranch> GetBankBranchesByBank(int BankNumber)
        {
            return dal.GetBankBranchesByBank(BankNumber);
        }
        #endregion


        #region PrePhones
        public List<string> GetPrePhones()
        {
            return dal.GetPrePhones();
        }
        #endregion


        #region GuestRequest

        //פונקציה להוספת בקשה
        public void AddGusetRequest(GuestRequest guestRequest, out Enums.GuestRequesteCreateStatus status)
        {
            status = Enums.GuestRequesteCreateStatus.Success;
            if (string.IsNullOrEmpty(guestRequest.FirstName) || (string.IsNullOrEmpty(guestRequest.LastName)) || string.IsNullOrEmpty(guestRequest.MailAddress))
            {
                status = Enums.GuestRequesteCreateStatus.MissingFields;
                return;
            }
            //if (guestRequest.GuestRequestsKey < 10000000)
            //{
            //    status = Enums.GuestRequesteCreateStatus.WrongFields;
            //    return;
            //}

                Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!regex.IsMatch(guestRequest.MailAddress))
                {
                    status = Enums.GuestRequesteCreateStatus.WrongFields;
                    return;
                }
          
            long id = 0;
            long.TryParse(guestRequest.PhoneExt, out id);
            if (id == 0)
            {
                status = Enums.GuestRequesteCreateStatus.WrongFields;
                return;
            }

            if (guestRequest.PhoneExt.Length < 7)
            {
                status = Enums.GuestRequesteCreateStatus.WrongFields;
                return;
            }
            if (guestRequest.ReleaseDate < guestRequest.EntryDate ||  guestRequest.EntryDate < DateTime.Now)
            {
                status = Enums.GuestRequesteCreateStatus.ErrorDates;
                return;
            }
            
            var hostings = dal.GetHostingUnits();
            int avilableHostings = 0;
            foreach (var hosting in hostings)
            {
                if (CheckForFreeDays(guestRequest, hosting))
                {
                    avilableHostings++;
                }
            }
            if (avilableHostings == 0)
            {
                status = Enums.GuestRequesteCreateStatus.NoHosting;
                return;
            }
            dal.AddGusetRequest(guestRequest);
        }

        //פונקציה שמעדכנת סטטוס בקשה
        public void UpdatingGusetRequest(GuestRequest guestRequest, Enums.GuestRequestStatus status)
        {
            if (guestRequest.Status == Enums.GuestRequestStatus.Closed || guestRequest.Status == Enums.GuestRequestStatus.ActiveAndClose)
            {
                return;
            }
            guestRequest.Status = status;
            dal.UpdatingGusetRequest(guestRequest, status);
        }
        
        //פונקציה שמקבלת בקשות עם אופציות של סינון
        public List<GuestRequest> GetGuestRequests(Func<GuestRequest, bool> predicate)
        {
           return dal.GetGuestRequests(predicate);
        }
       
        //פונקציה שמחזירה יחידות אירוח מתאימות לבקשה, עם אופציה לראות יחידות אירוח רק השייכים למארח
        public List<HostingUnit> GetRelevantHostingByRequest(GuestRequest guestRequest, int OwnerId = 0)
        {
            //יש לסנן גם לפי הOWNERID
            List<HostingUnit> hostings = dal.GetHostingUnits();
            List<HostingUnit> hostingsNew =  new List<HostingUnit>();

            foreach (HostingUnit hosting in hostings)
            {
                if ((OwnerId == 0 || hosting.OwnerId == OwnerId) && !CheckForFreeDays(guestRequest, hosting))
                {
                    hostingsNew.Add(hosting);
                }
            }
            return hostingsNew;
        }


       

        #endregion



        #region Order
         public void AddOrder(Order order, out Enums.OrderCreateStatus status)
        {
            status = Enums.OrderCreateStatus.Success;
            //מבצע בדיקה שמספר יחידת האירוח קיים  - סיום
          
            HostingUnit relatedHostings = dal.GetHostingUnits(c=>c.stSerialKey == order.HostingUnitKey).FirstOrDefault();
           
            if (relatedHostings == null)
            {
                status = Enums.OrderCreateStatus.ErrorInDetails;
                return;
            }
            //מבצע בדיקה שמספר הבקשה קיימת והסטטוס או פתוח או בתהליך - סיום
            GuestRequest guest  = dal.GetGuestRequests(c=>c.GuestRequestsKey == order.GuestRequestKey).FirstOrDefault();

            if (guest == null || guest.Status == Enums.GuestRequestStatus.Closed || guest.Status == Enums.GuestRequestStatus.ActiveAndClose ||  guest.Status == Enums.GuestRequestStatus.Expired)
            {
                status = Enums.OrderCreateStatus.ErrorInDetails;
                return;
            }

            //יוצר הזמנה - חסר


            //שליחת מייל ללקוח - סיום
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("kymsite@gmail.com");
                mail.To.Add(guest.MailAddress);
                mail.To.Add("g@geshtop.com");
                mail.To.Add("rivkistudies@gmail.com");
                mail.Subject = "נמצאה התאמה ליחידת האירוח ";
                string text = relatedHostings.ToString(); //מחזיר את היחידה הראשונה שמתאימה
                mail.Body = text;
                //mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("kymsite@gmail.com", "g9095398");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                status = Enums.OrderCreateStatus.MailFailed;
                return;
            }
            order.Status = Enums.OrderStatus.Mailed;
            dal.AddOrder(order);
            dal.UpdatingGusetRequest(guest, Enums.GuestRequestStatus.InProccess);
           
        }

        public void UpdatingOrder(Order order, Enums.OrderStatus status)
        {
            //if (order.Status == Enums.OrderStatus.Closes_in_response)
            //    return;
            order.Status = status;
            GuestRequest guest = dal.GetGuestRequests(c => c.GuestRequestsKey == order.GuestRequestKey).FirstOrDefault();
            HostingUnit relatedHostings = dal.GetHostingUnits(c=>c.stSerialKey == order.HostingUnitKey).FirstOrDefault();
           
            if (relatedHostings == null)
            {
              
                return;
            }
            if (guest == null || guest.Status == Enums.GuestRequestStatus.Closed || guest.Status == Enums.GuestRequestStatus.ActiveAndClose || guest.Status == Enums.GuestRequestStatus.Expired)
            {
               
                return;
            }

            if (status == Enums.OrderStatus.Success)
            {
                //יש לסמן את הימים ביחידות האירוח כמסומנים 
                dal.UpdatingGusetRequest(guest, Enums.GuestRequestStatus.ActiveAndClose);
                //יש לסגור את כל שאר ההזמנות המשוייכות לאותה בקשה
            }

            dal.UpdatingOrder(order, status);


        }

        public List<Order> GetOrders(Func<Order, bool> predicate, int OwnerId = 0)
        {

            return null;
        }
        
        #endregion

        public bool CheckForFreeDays(GuestRequest guestReq, HostingUnit unit)
        {
            DateTime first = guestReq.EntryDate;
            first = first.AddDays(1);
            DateTime last = guestReq.ReleaseDate;
            last = last.AddDays(-1);
            for (DateTime date = first ; date  <  last; date = date.AddDays(1))
            {
                if (unit.DiaryState.Calender[date.Month-1, date.Day-1] == true)
                    return false;
            }
            return true;
        }
        public List<HostingUnit> checkHostToRequest(List<HostingUnit> units, GuestRequest guest)
        {
            List<HostingUnit> hostingUnitNew = null;
            foreach (HostingUnit unit in units)
            {
                if(unit.Area == guest.Area && unit.Rooms >= guest.Rooms && unit.SubArea == guest.SubArea && unit.Type == guest.Type)
                {
                    hostingUnitNew.Add(unit);
                }
            }
            return hostingUnitNew;
        }
    }
}
