using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public class Dal_imp : Idal
    {


        private List<Host> _HostsList;
        private List<Host> HostsList
        {
            get
            {
                if (_HostsList == null)
                {
                    _HostsList = Hosts.getHosts();
                }
                return _HostsList;
            }
        }

        private List<HostingUnit> _HostingUnitsList;
        private List<HostingUnit> HostingUnitsList
        {
            get
            {
                if (_HostingUnitsList == null)
                {
                    _HostingUnitsList = TempData.getHostingUnits();
                }
                return _HostingUnitsList;
            }
        }

        private List<string> _PhonePreList;
        private List<string> PhonePreList
        {
            get
            {
                if (_PhonePreList == null)
                {
                    _PhonePreList = TempData.getPrePhones();
                }
                return _PhonePreList;
            }
        }


        private List<Bank> _BanksList;
        private List<Bank> BanksList
        {
            get
            {
                if (_BanksList == null)
                {
                    _BanksList = TempData.getBanks();
                }
                return _BanksList;
            }
        }

        private List<BankBranch> _BranchList;
        private List<BankBranch> BranchList
        {
            get
            {
                if (_BranchList == null)
                {
                    _BranchList = TempData.getBranches();
                }
                return _BranchList;
            }
        }



        private List<GuestRequest> _GuestRequestList;
        private List<GuestRequest> GuestRequestList
        {
            get
            {
                if (_GuestRequestList == null)
                {
                    _GuestRequestList = new List<GuestRequest>();
                }
                return _GuestRequestList;
            }
        }


        #region Hosts


        public List<Host> GetAllHosts(Func<Host, bool> predicate = null)
        {
            if (predicate!= null)
            {
                return HostsList.Where(predicate).ToList();
            }
            else
            {
                return HostsList;
            }
           
        }
        public void DeleteHost(int Id)
        {
            int index = HostsList.FindIndex(c => c.Id == Id);
            if (index > -1)
            {
                HostsList.RemoveAt(index);
            }
        }

        public Host GetHostById(int Id)
        {
            var host = HostsList.FirstOrDefault(c => c.Id == Id);
            host.RelatedHostingUnit = HostingUnitsList.Where(c => c.OwnerId == Id).ToList();
            return host;
        }

        public void UpdateHost(Host host)
        {
            var h = GetHostById(host.Id);
            if (h != null)
            {
                h.FirstName = host.FirstName;
                h.LastName = host.LastName;
                h.MailAddress = host.MailAddress;
                h.PhoneExt = host.PhoneExt;
                h.PhonePre = host.PhonePre;
                h.HostKey = host.HostKey;
            }
        }

        public void AddHost(Host host)
        {
            host.Id = Configuration.HostIdentity;
            Configuration.HostIdentity++;
            HostsList.Add(host);
        }
        #endregion

        #region HostingUnits


        public List<BE.HostingUnit> GetHostingUnits(Func<BE.HostingUnit, bool> predicate = null)
        {
            return  HostingUnitsList;
        }

        public HostingUnit GetHostingUnitById(int stSerialKey)
        {
            return HostingUnitsList.FirstOrDefault(c => c.stSerialKey == stSerialKey);
        }

        public void AddHostingUnit(BE.HostingUnit hostingUnit)
        {
            hostingUnit.stSerialKey = Configuration.HostingUnitKey;
            Configuration.HostingUnitKey++;
            HostingUnitsList.Add(hostingUnit);
        }

        public void DeleteHostingUnit(BE.HostingUnit hostingUnit)
        {
            int index = HostingUnitsList.FindIndex(c => c.stSerialKey == hostingUnit.stSerialKey);
            if (index > -1)
            {
                HostingUnitsList.RemoveAt(index);
            }
        }

        public void UpdatingHostingUnit(BE.HostingUnit hostingUnit, Enums.HosignUnitStatus status)
        {
            var h = GetHostingUnitById(hostingUnit.stSerialKey);
            if (h != null)
            {
                h.HostingUnitName = hostingUnit.HostingUnitName;
                h.Rooms = hostingUnit.Rooms;
                h.SubArea = hostingUnit.SubArea;
                h.OwnerId = hostingUnit.OwnerId;
                h.Pool = hostingUnit.Pool;
                h.Adult = hostingUnit.Adult;
                h.Area = hostingUnit.Area;
                h.Children = hostingUnit.Children;
                h.ChildrensAttractions = hostingUnit.ChildrensAttractions;
                h.Garden = hostingUnit.Garden;
                //h.
                h.Status = status;
                h.DiaryState = hostingUnit.DiaryState;
            }
        }


       
        #endregion

        #region Banks
         public List<Bank> GetBanksList()
        {
            return BanksList;
        }
        #endregion

        #region Branch

         public List<BankBranch> GetBankAccounts(Func<BankBranch, bool> predicate)
         {
             throw new NotImplementedException();
         }


         public List<BankBranch> GetBankBranches(Func<BankBranch, bool> predicate)
         {
             return BranchList;
         }

         public List<BankBranch> GetBankBranchesByBank(int BankNumber)
         {
             return BranchList.Where(c => c.BankNumber == BankNumber).ToList();
         }
         #endregion

         #region PrePhones
         public List<string> GetPrePhones()
         {
             return PhonePreList;
         }
         #endregion


         #region Guest Request
         public void AddGusetRequest(GuestRequest guestRequest)
         {
             //throw new NotImplementedException();
         }

         public void UpdatingGusetRequest(GuestRequest guestRequest, Enums.GuestRequestStatus status)
         {
             throw new NotImplementedException();
         }

         public List<GuestRequest> GetGuestRequests(Func<GuestRequest, bool> predicate)
         {
             throw new NotImplementedException();
         }
         #endregion


      

      

        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void UpdatingOrder(Order order, Enums.OrderStatus status)
        {
            throw new NotImplementedException();
        }

      

      

        public List<Order> GetOrders(Func<Order, bool> predicate)
        {
            throw new NotImplementedException();
        }

       
    }
}
