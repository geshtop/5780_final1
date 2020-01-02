using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public class Dal : DAL.IDal 
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
                    _GuestRequestList = TempData.getRequests();
                }
                return _GuestRequestList;
            }
        }

        private List<Order> _OrderList;
        private List<Order> OrderList
        {
            get
            {
                if (_OrderList == null)
                {
                    _OrderList = TempData.getOrders();
                }
                return _OrderList;
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
             guestRequest.GuestRequestsKey = Configuration.GuestRequestKey;
             Configuration.GuestRequestKey++;
             guestRequest.Status = Enums.GuestRequestStatus.Opened;
             guestRequest.RegistrationDate = DateTime.Now;
             GuestRequestList.Add(guestRequest);
         }

         public void UpdatingGusetRequest(GuestRequest guestRequest, Enums.GuestRequestStatus status )
         {
             int index = GuestRequestList.FindIndex(c => c.GuestRequestsKey == guestRequest.GuestRequestsKey);
             if (index > -1)
             {
                 GuestRequestList[index].Status = status;

               

            }
        }

         public List<GuestRequest> GetGuestRequests(Func<GuestRequest, bool> predicate = null)
         {
             if (predicate != null)
             {
                 return GuestRequestList.Where(predicate).ToList();
             }
             else
             {
                 return GuestRequestList;
             }
           
         }
        #endregion


        #region order



        public void AddOrder(Order order)
        {
            order.OrderKey = Configuration.OrderKey;
            Configuration.OrderKey++;
            order.CreateDate = DateTime.Now;
            OrderList.Add(order);
        }

        public void UpdatingOrder(Order order, Enums.OrderStatus status)
        {
            int index = OrderList.FindIndex(c => c.OrderKey == order.OrderKey);
            if (index > -1)
            {
                OrderList[index].Status = status;

                if (status == Enums.OrderStatus.Success)
                {
                    //עדכון של שאר ההזמנות
                    var orders = OrderList.FindAll(c => c.GuestRequestKey == order.GuestRequestKey);
                    foreach (var orderi in orders)
                    {
                        orderi.Status = Enums.OrderStatus.Closed;
                    }

                    //עדכון הימים באכסניה
                    
                    int hostingid = HostingUnitsList.FindIndex(c => c.stSerialKey == order.HostingUnitKey);
                    var request =GuestRequestList.Where(c=>c.GuestRequestsKey == order.GuestRequestKey).FirstOrDefault();
                    if(hostingid > -1 && request != null){
                    Diary diary = HostingUnitsList[hostingid].DiaryState;
                    for (DateTime time = request.EntryDate.AddDays(1); time < request.ReleaseDate; time = time.AddDays(1))
                    {
                        diary.Calender[time.Month - 1, time.Day - 1] = true;
                    }
                        // HostingUnitsList[key].DiaryState = diary;
                    }
                    OrderList[index].Status = Enums.OrderStatus.Success; //אני לא יודעת אם סטטוס ההזמנה המקורית השנה אף הוא
                }

            }
        }

        public List<Order> GetOrders(Func<Order, bool> predicate = null)
        {
            return OrderList.Where(predicate).ToList();
        }

        #endregion
    }
}
