using BE;
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

namespace PL.Controls
{
    /// <summary>
    /// Interaction logic for GuestRequestListItem.xaml
    /// </summary>
    public partial class GuestRequestListItem : UserControl
    {
        public AppLogic app { get; set; }
        public GuestRequest CurrGuestRequest { get; set; }
        public List<HostingUnit> relatedHosting { get; set; }
        public int OwnerId { get; set; }
        public GuestRequestListItem(GuestRequest _CurrGuestRequest,  AppLogic _app, int _OwnerId)
        {
            this.app = _app;
            this.CurrGuestRequest = _CurrGuestRequest;
            this.OwnerId = _OwnerId;
            relatedHosting = app.GetRelevantHostingByRequest(CurrGuestRequest, OwnerId);
            InitializeComponent();
            GuestGrid.DataContext = CurrGuestRequest;


            CBRelatedHostings.ItemsSource = relatedHosting;
            CBRelatedHostings.DisplayMemberPath = "HostingUnitName";
            CBRelatedHostings.SelectedValuePath = "stSerialKey";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void CBRelatedHostings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (int.Parse(CBRelatedHostings.SelectedValue.ToString()) > 0)
            {
                CreateOrder.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void CreateOrder_Click(object sender, RoutedEventArgs e)
        {
            Enums.OrderCreateStatus state;
            Order o = new Order();
            o.GuestRequestKey = CurrGuestRequest.GuestRequestsKey;
            o.HostingUnitKey = int.Parse(CBRelatedHostings.SelectedValue.ToString());
            app.AddOrder(o, out state);
        }

       
    }
}
