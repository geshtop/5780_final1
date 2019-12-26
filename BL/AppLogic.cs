using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void AddGusetRequest(GuestRequest guestRequest )
        {
            //add validation
            dal.AddGusetRequest(guestRequest);
        }
        //פונקציה שמעדכנת סטטוס בקשה
        public void UpdatingGusetRequest(GuestRequest guestRequest, Enums.GuestRequestStatus status)
        {
            //add validation
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
            return null;
        }
        #endregion

    }
}
