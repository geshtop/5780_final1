using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    internal class Dal_imp //: Idal
    {
        #region Singleton
        private static readonly Dal_imp instance = new Dal_imp();
        public static Dal_imp Instance
        {
            get { return instance; }
        }

        private Dal_imp() { }
        static Dal_imp() { }

        #endregion
        public void AddGuestRequest(string id, string name, int age)
        {
            throw new NotImplementedException();
        }

        public void UpdatingGusetRequest(string stutus, GuestRequest guestRequest)
        {

        }

        public void AddHostingUnit(HostingUnit hostingUnit)
        {
            DataSource.hostingUnits.Add(hostingUnit);
        }

        public void DeleteHostingUnit(HostingUnit hostingUnit)
        {
            DataSource.hostingUnits.Remove(hostingUnit);
        }

        public void UpdatingHostingUnit(string stutus, HostingUnit hostingUnit)
        {

        }

        public void AddOrder(Order order)
        {
            DataSource.orders.Add(order);
        }

        public void UpdatingOrder(string stutus, HostingUnit hostingUnit)
        {

        }

        public List<HostingUnit> GetHostingUnits(Func<HostingUnit, bool> predicate = null)
        {
            return DataSource.hostingUnits.Where(predicate).ToList();
        }

        public List<GuestRequest> GetGuestRequests(Func<GuestRequest, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders(Func<Order, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public List<BankAccount> GetBankAccounts(Func<BankAccount, bool> predicate)
        {
            throw new NotImplementedException();
        }

        //public List<HostingUnit> GetAllHostingUnits()
        //{
        //    return DataSource.hostingUnits;
        //}
    }
}
