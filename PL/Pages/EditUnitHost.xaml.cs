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

namespace PL.Pages
{
    /// <summary>
    /// Interaction logic for EditUnitHost.xaml
    /// </summary>
    public partial class EditUnitHost : PageBase
    {
        protected HostingUnit CurrentHU { get; set; }
        public EditUnitHost(int id =0)
        {
            if (id > 0)
            {

            }
            else
            {
                CurrentHU = new HostingUnit();
            }
            InitializeComponent();
            hostEditGrid.DataContext = CurrentHU;
        }


        private void ShowPanel_Click(object sender, RoutedEventArgs e)
        {


            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    hostEditGrid.Visibility = System.Windows.Visibility.Visible;
                    hostingList.Visibility = System.Windows.Visibility.Hidden;
                    break;
                case 1:
                    hostEditGrid.Visibility = System.Windows.Visibility.Hidden;
                    hostingList.Visibility = System.Windows.Visibility.Visible;
                    break;
                case 2:
                   
                    break;

            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

            app.AddHostingUnit(CurrentHU);

        }


        
    }
}
