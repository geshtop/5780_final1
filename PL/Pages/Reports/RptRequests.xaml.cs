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

namespace PL.Pages.Reports
{
    /// <summary>
    /// Interaction logic for RptRequests.xaml
    /// </summary>
    public partial class RptRequests : PageBase
    {
        public RptRequests()
        {
            InitializeComponent();
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            int SelectedAreaId = 0 ;
            int.TryParse(FilterArea.SelectedValue.ToString(), out SelectedAreaId);
           
            //1 Get filters
            var list = app.GetGuestRequests(
                c => ( (c.LastName == FilterName.Text || c.FirstName == FilterName.Text ) || FilterName.Text == "")
                    && (c.MailAddress == FilterEmail.Text || FilterEmail.Text == "")
                    && (c.AreaId == SelectedAreaId || SelectedAreaId ==0)
                );

            //2 Fill the list view

            ListRequests.ItemsSource = list;
        }
        
    }
}
