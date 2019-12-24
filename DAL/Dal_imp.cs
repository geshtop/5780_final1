using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    internal class Dal_imp : Idal
    {

        public void AddGusetRequest(GuestRequest guestRequest)
        {
            throw new NotImplementedException();
        }

        public void UpdatingGusetRequest(GuestRequest guestRequest, Enums.GuestRequestStatus status)
        {
            throw new NotImplementedException();
        }

        public void AddHostingUnit(HostingUnit hostingUnit)
        {
            throw new NotImplementedException();
        }

        public void DeleteHostingUnit(HostingUnit hostingUnit)
        {
            throw new NotImplementedException();
        }

        public void UpdatingHostingUnit(HostingUnit hostingUnit, Enums.HosignUnitStatus status)
        {
            throw new NotImplementedException();
        }

        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void UpdatingOrder(Order order, Enums.OrderStatus status)
        {
            throw new NotImplementedException();
        }

        public List<HostingUnit> GetHostingUnits(Func<HostingUnit, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public List<GuestRequest> GetGuestRequests(Func<GuestRequest, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders(Func<Order, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public List<BankBranch> GetBankAccounts(Func<BankBranch, bool> predicate)
        {
            throw new NotImplementedException();
        }


        public List<BankBranch> GetBankBranches(Func<BankBranch, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
