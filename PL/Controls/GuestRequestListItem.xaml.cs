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
        public int OwnerId { get; set; }
        public string Data { get; set; }
        public GuestRequestListItem(GuestRequest _CurrGuestRequest,  AppLogic _app, int _OwnerId)
        {
            this.app = _app;
            this.CurrGuestRequest = _CurrGuestRequest;
            this.OwnerId = _OwnerId;
            this.Data = CurrGuestRequest.ToString();
            InitializeComponent();
            GuestGrid.DataContext = CurrGuestRequest;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Enums.OrderCreateStatus state;
            app.AddOrder(new Order(), out state);
        }
    }
}
