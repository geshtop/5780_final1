using BE;
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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : PageBase
    {
         
        public List<Host> HostList { get; set; }
        public Main()
        {
            HostList = app.GetAllHosts();
            InitializeComponent();


            CbHosts.ItemsSource = HostList;
            CbHosts.DisplayMemberPath = "FullName";
            CbHosts.SelectedValuePath = "Id";
        }



       
      

      

        private void ManageHosts_Click(object sender, RoutedEventArgs e)
        {

            HostList hostListPage = new HostList();
          
            MainNavigate(hostListPage);
          
           
        }

     

        private void AddReqest_Click(object sender, RoutedEventArgs e)
        {
            //check your logic
            EditGuestRequest requestPage = new EditGuestRequest();
            MainNavigate(requestPage);
          
        }

        private void GeustListButton_Click(object sender, RoutedEventArgs e)
        {
            GuestRequestList requestList = new GuestRequestList();
            MainNavigate(requestList);
           
        }

        private void CbHosts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (int.Parse(CbHosts.SelectedValue.ToString()) > 0)
            {
                OwnerId = int.Parse(CbHosts.SelectedValue.ToString());
                GeustListButton.Visibility =  System.Windows.Visibility.Visible;
            }
        }

        private void RequestByArea_Click(object sender, RoutedEventArgs e)
        {
            var requestgroup = app.GetGuestRequestsGrouingByArea();
          
        }

       
    }
}
