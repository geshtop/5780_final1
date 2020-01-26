﻿using PL.Pages.Reports;
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

namespace PL.Pages
{
    /// <summary>
    /// Interaction logic for ReportMainPage.xaml
    /// </summary>
    public partial class ReportMainPage : PageBase
    {
        public ReportMainPage()
        {
            InitializeComponent();
        }

        private void RequestButtonClick_Click(object sender, RoutedEventArgs e)
        {
            RptRequests requestpage = new RptRequests();
            ReportFrame.Content = requestpage;
        }

        private void HostingButtonClick_Click(object sender, RoutedEventArgs e)
        {
            Rhosting rhost = new Rhosting();
            ReportFrame.Content = rhost;
        }

        private void HostButtonClick_Click_1(object sender, RoutedEventArgs e)
        {
            Rhost rhost = new Rhost();
            ReportFrame.Content = rhost;
        }

        private void PayClick_Click(object sender, RoutedEventArgs e)
        {
            Rpay rpay = new Rpay();
            ReportFrame.Content = rpay;
        }
    }
}
