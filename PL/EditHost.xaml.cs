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
    /// Interaction logic for EditHost.xaml
    /// </summary>
    public partial class EditHost : Window
    {
        private  AppLogic app  { get; set; }
        public Host CurrHost { get; set; }
        public EditHost(AppLogic _app, Host _curr)
        {
            this.app = _app;
            this.CurrHost = _curr;
            InitializeComponent();
            hostEditGrid.DataContext = CurrHost;
            prePhoneCb.ItemsSource = app.PhonePreList;
            if (CurrHost.Id > 0) //אם המדובר על עריכה
            {
                IdTxt.IsReadOnly = true;
              
            }
            else //מדובר על רשומה חדשה
            {
               
            }

            BankBranchSelector bs = new BankBranchSelector(app, CurrHost);
            hostEditGrid.Children.Add(bs);
            bs.Margin = new Thickness(76, 21, 0, 0);
            Grid.SetColumn(bs, 1);
            Grid.SetRow(bs, 7);
           
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrHost.Id > 0)
            {
                app.UpdateHost(CurrHost);
            }
            else
            {
                app.AddHost(CurrHost);
            }
           
            BackToList();
          
        }


        private void BackToList_Click(object sender, RoutedEventArgs e)
        {
           

            BackToList();

        }
       


        private void BackToList(){
            this.Close();
             HostList hostListPage = new HostList(this.app);
            hostListPage.ShowDialog();
           
        }
    }
}
