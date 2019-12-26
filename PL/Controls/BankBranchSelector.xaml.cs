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
    /// Interaction logic for BankBranchSelector.xaml
    /// </summary>
    public partial class BankBranchSelector : UserControl
    {
        private AppLogic app { get; set; }
        public Host CurrHost { get; set; }
        public List<Bank> BankList { get; set; }
        public List<Bank> BranchList { get; set; }
        public BankBranchSelector(AppLogic _app, Host _CurrHost)
        {
            this.app = _app;
            this.CurrHost = _CurrHost;
            BankList = this.app.GetBanksList();
            InitializeComponent();
            BankBranchGrid.DataContext = CurrHost;
            BankCb.ItemsSource =BankList;
            BankCb.DisplayMemberPath = "BankName";
            BankCb.SelectedValuePath = "BankCode";
            BranchCb.DisplayMemberPath = "BranchNameAndNum";
            BranchCb.SelectedValuePath = "BranchNumber";
            ReloadBranches();




        }

        private void ReloadBranches()
        {
            if (CurrHost.BankNumber > 0)
            {
                BranchCb.ItemsSource = app.GetBankBranchesByBank(CurrHost.BankNumber);
            }
        }

        private void BankCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ReloadBranches();
        }
    }
}
