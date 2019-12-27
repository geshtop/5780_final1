using BE;
using BL;
using PL.Controls;
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
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for GuestRequestList.xaml
    /// </summary>
    public partial class GuestRequestList : Window
    {
        public AppLogic app { get; set; }
        public int OwnerId { get; set; }
        public List<GuestRequest> RequestsList { get; set; }
        public GuestRequestList( AppLogic _app, int _OwnerId)
        {
            this.app = _app;
            this.OwnerId = _OwnerId;
            RequestsList = app.GetGuestRequests(c => c.Status == Enums.GuestRequestStatus.Opened || c.Status == Enums.GuestRequestStatus.InProccess);
            InitializeComponent();
            FillGrid();
        }


        private void FillGrid()
        {
            GuestRequestListGrid.DataContext = RequestsList;
            for (int i = 0; i < RequestsList.Count; i++)
            {
                GuestRequestListItem reqCtrl = new GuestRequestListItem( RequestsList[i], app, OwnerId);
                GuestRequestListGrid.Children.Add(reqCtrl);
                GuestRequestListGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(185) });
                Grid.SetRow(reqCtrl, i + 1);
            }
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            //(App.Current.MainWindow as MainWindow).Show();

        }

    }
}
