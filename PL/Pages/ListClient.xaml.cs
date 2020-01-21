using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using BE;
using BL;

namespace PL.Pages
{
    /// <summary>
    /// Interaction logic for ListClient.xaml
    /// </summary>
    public partial class ListClient : PageBase
    {
        enum filterRequest { everything, status, area, type, stars }
        ObservableCollection<IGrouping<Enums.HostingUnitArea, GuestRequest>> groupedByArea;
        public ListClient()
        {
            InitializeComponent();
        }

        private void Stutus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            switch (Stutus.SelectedItem)
            {
                case 0:
            //        cbbShowGroup.SelectedItem = null;
            //        cbbShowGroup.IsEnabled = false;
            //        requestsList = new ObservableCollection<GuestRequest>(MainWindow.myBL.GetGuestRequestsList());
            //        requestView.ItemsSource = requestsList;
                    break;
                case 1:
                //    groupedByStatus = new ObservableCollection<IGrouping<Enums.GuestRequestStatus, GuestRequest>>(MainWindow.myBL.GroupGRByStatus());
                //    Enums.GuestRequestStatus[] keysOfstatus = (from item in groupedByStatus select item.Key).ToArray();
                //    cbbShowGroup.ItemsSource = keysOfstatus;
                //    cbbShowGroup.IsEnabled = true;
                //    cbbShowGroup.SelectedItem = 0;
                    break;
                case "לפי אזור נופש":
                    groupedByArea = new ObservableCollection<IGrouping<Enums.HostingUnitArea, GuestRequest>>(app.GroupGRByArea());
                    Enums.HostingUnitArea[] keysOfArea = (from item in groupedByArea select item.Key).ToArray();
                    Stutus.ItemsSource = keysOfArea;
                    Stutus.IsEnabled = true;
                    Stutus.SelectedItem = 0;
                    break;
                case 3:
                //    groupedByType = new ObservableCollection<IGrouping<Enums.HostingUnitType, GuestRequest>>(MainWindow.myBL.GroupGRByType());
                //    Enums.HostingUnitType[] keysOfType = (from item in groupedByType select item.Key).ToArray();
                //    cbbShowGroup.ItemsSource = keysOfType;
                //    cbbShowGroup.IsEnabled = true;
                //    cbbShowGroup.SelectedItem = 0;
                    break;
                case 4:
                //    groupedByStars = new ObservableCollection<IGrouping<int, GuestRequest>>(MainWindow.myBL.GroupGRByStars());
                //    int[] keysOfStars = (from item in groupedByStars select item.Key).ToArray();
                //    cbbShowGroup.ItemsSource = keysOfStars;
                //    cbbShowGroup.IsEnabled = true;
                //    cbbShowGroup.SelectedItem = 0;
                    break;
            }

        }
    }
}
