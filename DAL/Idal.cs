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
        void AddGusetRequest(string id, string name, int age);
        void UpdatingGusetRequest(string stutus, GuestRequest guestRequest);

        void AddHostingUnit(HostingUnit hostingUnit);
        void DeleteHostingUnit(HostingUnit hostingUnit);
        void UpdatingHostingUnit(string stutus, HostingUnit hostingUnit);

        void AddOrder(Order order);
        void UpdatingOrder(string stutus, HostingUnit hostingUnit);

        List<HostingUnit> GetHostingUnits(Func<HostingUnit, bool> predicate = null);
        List<GuestRequest> GetGuestRequests(Func<GuestRequest, bool> predicate);
        List<Order> GetOrders(Func<Order, bool> predicate);

        List<BankAccount> GetBankAccounts(Func<BankAccount, bool> predicate);
    }
}
