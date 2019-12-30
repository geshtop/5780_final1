﻿using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppLogic app { get; set; }
        public int CurrOwner { get; set; }
        public List<Host> HostList { get; set; }
        public MainWindow()
        {
            this.app = new AppLogic();
            HostList = app.GetAllHosts();
          
           
            InitializeComponent();


            

            if (HostList.Count > 0)
            {
                CurrOwner = HostList[0].Id;
                
            }

            CbHosts.ItemsSource = HostList;
            CbHosts.DisplayMemberPath = "FullName";
            CbHosts.SelectedValuePath = "Id";
        }

      

        private void ManageHosts_Click(object sender, RoutedEventArgs e)
        {

            HostList hostListPage = new HostList(this.app);
            hostListPage.ShowDialog();
           
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddReqest_Click(object sender, RoutedEventArgs e)
        {
            //check your logic
            EditGuestRequest requestPage = new EditGuestRequest(this.app);
            requestPage.ShowDialog();
          
        }

        private void GeustListButton_Click(object sender, RoutedEventArgs e)
        {
            GuestRequestList requestList = new GuestRequestList(app, CurrOwner);
            requestList.ShowDialog();
        }
    }
}
