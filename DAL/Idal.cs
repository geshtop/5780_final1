using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface Idal
    {
        void AddGusetRequest(GuestRequest guestRequest);
        void UpdatingGusetRequest(GuestRequest guestRequest, Enums.GuestRequestStatus status);

        void AddHostingUnit(HostingUnit hostingUnit);
        void DeleteHostingUnit(HostingUnit hostingUnit);
        void UpdatingHostingUnit( HostingUnit hostingUnit, Enums.HosignUnitStatus status);

        void AddOrder(Order order);
        void UpdatingOrder(Order order,Enums.OrderStatus status);

        List<HostingUnit> GetHostingUnits(Func<HostingUnit, bool> predicate = null);
        List<GuestRequest> GetGuestRequests(Func<GuestRequest, bool> predicate);
        List<Order> GetOrders(Func<Order, bool> predicate);

        List<BankBranch> GetBankBranches(Func<BankBranch, bool> predicate);
    }
}
