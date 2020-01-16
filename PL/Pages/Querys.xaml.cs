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
    /// Interaction logic for Querys.xaml
    /// </summary>
    public partial class Querys : PageBase
    {
        public Querys()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) // חדרי אירוח
        {
            ListHostingUnits listHostingUnits = new ListHostingUnits();
            MainNavigate(listHostingUnits);
        }

        private void Client_Click(object sender, RoutedEventArgs e) //אורחים
        {
            ListClient listClient = new ListClient();
            MainNavigate(listClient);
        }

        private void Hosts_Click(object sender, RoutedEventArgs e) //הזמנות
        {
            OrderByRequest orderByRequest = new OrderByRequest();
            MainNavigate(orderByRequest);
        }
    }
}
