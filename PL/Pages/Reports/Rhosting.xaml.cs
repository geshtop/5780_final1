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
using BE;

namespace PL.Pages.Reports
{
    /// <summary>
    /// Interaction logic for Rhost.xaml
    /// </summary>
    public partial class Rhosting : PageBase
    {
        public Rhosting()
        {
            InitializeComponent();
            ListRequests.ItemsSource = app.GetHostingUnits();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string num = "0";
            num = NumRooms.Text;
            int trye = int.Parse(num);

            int SelectedAreaId = 0;
            SelectedAreaId = FilterArea.TabIndex;
            //int.TryParse(FilterArea.SelectedValue.ToString(), out SelectedAreaId);

            //1 Get filters
            var list = app.GetHostingUnits(
                c => ((c.HostingUnitName == FilterName.Text || c.HostingUnitName == FilterName.Text) || FilterName.Text == "")
                    && (c.Rooms == trye || trye == 0)
                    && (c.AreaId == SelectedAreaId || SelectedAreaId == 0)
                );

            //2 Fill the list view

            ListRequests.ItemsSource = list;
        }
    }
}
