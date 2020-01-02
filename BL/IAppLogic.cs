using System;
namespace BL
{
    public interface IAppLogic
    {
        void AddGusetRequest(BE.GuestRequest guestRequest, out BE.Enums.GuestRequesteCreateStatus status);
        void AddHost(BE.Host host, out BE.Enums.HostValidationStatus status);
        void AddHostingUnit(BE.HostingUnit hostingUnit);
        void AddOrder(BE.Order order, out BE.Enums.OrderCreateStatus status);
        bool CheckForFreeDays(BE.GuestRequest guestReq, BE.HostingUnit unit);
        void DeleteHost(int Id);
        void DeleteHostingUnit(BE.HostingUnit hostingUnit);
        System.Collections.Generic.List<BE.Host> GetAllHosts();
        System.Collections.Generic.List<BE.BankBranch> GetBankBranches(Func<BE.BankBranch, bool> predicate);
        System.Collections.Generic.List<BE.BankBranch> GetBankBranchesByBank(int BankNumber);
        System.Collections.Generic.List<BE.Bank> GetBanksList();
        System.Collections.Generic.List<BE.GuestRequest> GetGuestRequests(Func<BE.GuestRequest, bool> predicate);
        System.Collections.Generic.List<System.Collections.Generic.List<BE.GuestRequest>> GetGuestRequestsGrouingByArea();
        BE.Host GetHostById(int Id);
        BE.HostingUnit GetHostingUnitById(int stSerialKey);
        System.Collections.Generic.List<BE.HostingUnit> GetHostingUnits(Func<BE.HostingUnit, bool> predicate = null);
        System.Collections.Generic.List<BE.Order> GetOrders(Func<BE.Order, bool> predicate, int OwnerId = 0);
        System.Collections.Generic.List<string> GetPrePhones();
        System.Collections.Generic.List<BE.RelatedHosting> GetRelevantHostingByRequest(BE.GuestRequest guestRequest, int OwnerId = 0);
        System.Collections.Generic.List<BE.HostingUnit> HostingUnitList(DateTime time, int numDay);
        int NumDays(DateTime start, DateTime? end = null);
        System.Collections.Generic.List<BE.Order> OrderFromTime(int numDay);
        int Orders(BE.GuestRequest guestRequest);
        int Orders(BE.HostingUnit hostingUnit);
        void UpdateHost(BE.Host host, out BE.Enums.HostValidationStatus status);
        void UpdatingGusetRequest(BE.GuestRequest guestRequest, BE.Enums.GuestRequestStatus status);
        void UpdatingHostingUnit(BE.HostingUnit hostingUnit, BE.Enums.HosignUnitStatus status);
        bool UpdatingOrder(int OrderId, BE.Enums.OrderStatus status);
    }
}
