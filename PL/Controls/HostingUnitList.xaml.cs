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
    /// Interaction logic for HostingUnitList.xaml
    /// </summary>
    public partial class HostingUnitList : UserControl
    {
        public List<HostingUnit> list { get; set; }
        private IAppLogic app { get; set; }
        public HostingUnitList(List<HostingUnit> _list, IAppLogic _app)
        {
            this.app = _app;
            this.list = _list;
            InitializeComponent();
            FillGrid();
           
        }

        private void FillGrid()
        {
            HostingListGrid.DataContext = list;
            for (int i = 0; i < list.Count; i++)
            {
                UnitHostingCtrl hostingCtrl = new UnitHostingCtrl(list[i], app);
                HostingListGrid.Children.Add(hostingCtrl);
                HostingListGrid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(150) });
                Grid.SetRow(hostingCtrl, i);
            }
        }
       
    }
}
