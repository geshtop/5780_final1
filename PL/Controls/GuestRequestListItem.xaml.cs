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
        IAppLogic app;
        public GuestRequest CurrGuestRequest { get; set; }
        public List<RelatedHosting> relatedHosting { get; set; }
      
        public int OwnerId { get; set; }
        public GuestRequestListItem(GuestRequest _CurrGuestRequest, IAppLogic _app, int _OwnerId)
        {
            this.app = _app;
            this.CurrGuestRequest = _CurrGuestRequest;
            this.OwnerId = _OwnerId;
            relatedHosting = app.GetRelevantHostingByRequest(CurrGuestRequest, OwnerId);
            InitializeComponent();
            GuestGrid.DataContext = CurrGuestRequest;


            lvUsers.ItemsSource = relatedHosting;

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
            var b = (Button)sender;
            if (b != null)
            {
                int id = Int32.Parse(b.Tag.ToString());

                Enums.OrderCreateStatus state;
                Order o = new Order();
                o.GuestRequestKey = CurrGuestRequest.GuestRequestsKey;
                o.HostingUnitKey = id;
                app.AddOrder(o, out state);
                string mess = "";
                switch (state)
                {
                    case Enums.OrderCreateStatus.Success:
                        mess = "המייל נשלח בהצלחה";
                        break;
                    case Enums.OrderCreateStatus.ErrorInDetails:
                        mess = "שגיאה";
                        break;
                    case Enums.OrderCreateStatus.MailFailed:
                        mess = "שגיאה";
                        break;
                    default:
                        break;
                }
                MessageBox.Show(mess);


                RefreshWindow();
                

            }
           
        }


        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            var b = (Button)sender;
            if (b != null)
            {
                int orderid = Int32.Parse(b.Tag.ToString());

                bool success = app.UpdatingOrder(orderid, Enums.OrderStatus.Success);
                MessageBox.Show((success)?"ההזמנה בוצעה בהצלחה":"שגיאה");

                RefreshWindow();
               


            }

        }

        private void RefreshWindow()
        {
            Window yourParentWindow = Window.GetWindow(this);
            yourParentWindow.Close();
            GuestRequestList requestList = new GuestRequestList(app, OwnerId);

            requestList.ShowDialog();
        }
    }
}
