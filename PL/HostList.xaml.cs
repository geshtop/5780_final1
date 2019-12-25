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
    /// Interaction logic for HostList.xaml
    /// </summary>
    public partial class HostList : Window
    {
        private AppLogic app { get; set; }
        public HostList(AppLogic _app)
        {
            this.app = _app;
            InitializeComponent();
            FillGrid();
        }

        public void Refresh()
        {
            FillGrid();
        }

        private void FillGrid(){
            HostsGrid.DataContext = this.app.HostsList;
            for (int i = 0; i < this. app.HostsList.Count; i++)
            {
                UnitHost hostCtrl = new UnitHost(app.HostsList[i], app);
                //hostCtrl.CurrHost = app.HostsList[i];

                HostsGrid.Children.Add(hostCtrl);
                HostsGrid.RowDefinitions.Add(new RowDefinition() {  Height =  new GridLength(40)  });
                Grid.SetRow(hostCtrl, i +1);
            }
        }

        private void AddHost_Click(object sender, RoutedEventArgs e)
        {
            
            EditHost hostPage = new EditHost(this.app, new Host());
            hostPage.ShowDialog();
        }
    }
}
