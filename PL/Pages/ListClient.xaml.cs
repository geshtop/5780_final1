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
using PL.Controls;

namespace PL.Pages
{
    /// <summary>
    /// Interaction logic for ListClient.xaml
    /// </summary>
    public partial class ListClient : PageBase
    {
        public List<GuestRequest> GuestRequests { get; set; }
        public ListClient()
        {
            InitializeComponent();
            Stutus.Items.Add("לפי שם פרטי");
            Stutus.Items.Add("לפי שם משפחה");
            Stutus.Items.Add("לפי אזור");
            Stutus.Items.Add("לפי מספר נופשים ");
            Stutus.Items.Add("לפי תאריכים");
            GuestRequests = app.GetGuestRequests();
            FillGrid();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            if (!Stutus_Copy1.Items.IsEmpty)
                Stutus_Copy1.Items.Clear();
            Stutus_Copy1.Items.Add("הכל");
            Stutus_Copy1.Items.Add("צפון");
            Stutus_Copy1.Items.Add("דרום");
            Stutus_Copy1.Items.Add("מזרח");
            Stutus_Copy1.Items.Add("ירושלים");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stutus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void FillGrid()
        {
            ShowsList.DataContext = GuestRequests;

            for (int i = 0; i < GuestRequests.Count; i++)
            {
                //UnitHost hostCtrl = new UnitHost(GuestRequests[i]);
                ShowsList.Items.Add(GuestRequests[i]);
                //ShowsList.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(50) });
                Grid.SetRow(ShowsList, i + 1);
            }
        }
    }
}
