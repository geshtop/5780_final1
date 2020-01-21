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
        public ListClient()
        {
            InitializeComponent();
            
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
            List<GuestRequest> guestRequests = app.ReturnArea("הכל");
            if (guestRequests == null)
                return;
            ShowsList.DataContext = guestRequests;
        }
    }
}
