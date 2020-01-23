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

namespace PL.Pages.Reports
{
    /// <summary>
    /// Interaction logic for Rhost.xaml
    /// </summary>
    public partial class Rhost : PageBase
    {
        public Rhost()
        {
            InitializeComponent();
            ListRequestsHost.ItemsSource = app.GetAllHosts();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var list = app.GetAllHosts(
              c => ((c.LastName == FilterName.Text || c.FirstName == FilterName.Text) || FilterName.Text == "")
                  && (c.Phone == FilterPhone.Text || FilterPhone.Text == "")
                  && (c.MailAddress == GmailAdress.Text || GmailAdress.Text == "")
              );

            ListRequestsHost.ItemsSource = list;
        }
    }
}
