using System;
using System.Collections.Generic;
using BE;

namespace BL
{
    public interface IAppLogic
    {
        void AddHost(Host host, out Enums.HostValidationStatus status);
        void DeleteHost(int Id);
        List<Host> GetAllHosts();



        void AddGusetRequest(GuestRequest guestRequest, out Enums.GuestRequesteCreateStatus status);
        List<GuestRequest> GetGuestRequests(Func<GuestRequest, bool> predicate);
     


        void AddHostingUnit(HostingUnit hostingUnit);
        void DeleteHostingUnit(HostingUnit hostingUnit);

        void AddOrder(Order order, out Enums.OrderCreateStatus status);






        List<BankBranch> GetBankBranches(Func<BankBranch, bool> predicate);
        List<BankBranch> GetBankBranchesByBank(int BankNumber);
        List<Bank> GetBanksList();

        Host GetHostById(int Id);
        HostingUnit GetHostingUnitById(int stSerialKey);
        List<HostingUnit> GetHostingUnits(Func<HostingUnit, bool> predicate = null);
        List<Order> GetOrders(Func<Order, bool> predicate, int OwnerId = 0);
        List<string> GetPrePhones();
        List<RelatedHosting> GetRelevantHostingByRequest(GuestRequest guestRequest, int OwnerId = 0);
        void UpdateHost(Host host, out Enums.HostValidationStatus status);
        void UpdatingGusetRequest(GuestRequest guestRequest, Enums.GuestRequestStatus status);
        void UpdatingHostingUnit(HostingUnit hostingUnit, Enums.HosignUnitStatus status);
        bool UpdatingOrder(int OrderId, Enums.OrderStatus status);
    }
}