﻿using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AppLogic
    {
        private List<Host> _HostsList;
        public List<Host> HostsList {
            get
            {
                if (_HostsList == null)
                {
                    _HostsList = Hosts.getHosts();
                }
                return _HostsList;
            }
        }


        private List<string> _PhonePreList;
        public List<string> PhonePreList
        {
            get
            {
                if (_PhonePreList == null)
                {
                    _PhonePreList = PrePhones.getPrePhones();
                }
                return _PhonePreList;
            }
        }


        private List<Bank> _BanksList;
        public List<Bank> BanksList
        {
            get
            {
                if (_BanksList == null)
                {
                    _BanksList = Banks.getBanks();
                }
                return _BanksList;
            }
        }

        private List<BankBranch> _BranchList;
        public List<BankBranch> BranchList
        {
            get
            {
                if (_BranchList == null)
                {
                    _BranchList = Branches.getBranches();
                }
                return _BranchList;
            }
        }


        #region Hosts
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
            return HostsList.FirstOrDefault(c => c.Id == Id);
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
       
    }
}