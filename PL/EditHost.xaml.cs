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
        IAppLogic app;
        public Host CurrHost { get; set; }
        public List<string> PhonePreList { get; set; }
        public EditHost(IAppLogic _app, Host _curr)
        {
           
            this.app = _app;
            PhonePreList = app.GetPrePhones();
            this.CurrHost = _curr;
            InitializeComponent();
            hostEditGrid.DataContext = CurrHost;
            prePhoneCb.ItemsSource = PhonePreList;
            if (CurrHost.Id > 0) //אם המדובר על עריכה
            {
                IdTxt.IsReadOnly = true;
              
            }
            else //מדובר על רשומה חדשה
            {
               
            }

            BankBranchSelector bs = new BankBranchSelector(app, CurrHost);
            hostEditGrid.Children.Add(bs);
            bs.Margin = new Thickness(10,15, 0, 0);
            Grid.SetColumn(bs, 1);
            Grid.SetRow(bs, 7);


            HostingUnitList hostingListCtrl = new HostingUnitList(CurrHost.RelatedHostingUnit, app);
            hostingList.Children.Add(hostingListCtrl);
          
           
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var state  = Enums.HostValidationStatus.Success;
            if (CurrHost.Id > 0)
            {
                app.UpdateHost(CurrHost, out state);
            }
            else
            {
                app.AddHost(CurrHost, out state);
            }

            if (state != Enums.HostValidationStatus.Success)
            {
                string ErrorMessage = "";
                switch (state)
                {
                   
                    case Enums.HostValidationStatus.MissingFields:
                        ErrorMessage = "יש למלא שדות חובה";
                        break;
                    case Enums.HostValidationStatus.DuplicateId:
                        ErrorMessage = "תעודת זהות קיימת כבר במערכת";
                        break;
                    case Enums.HostValidationStatus.WrongFields:
                        ErrorMessage ="מבנה שדות שגויים";
                        break;
                    case Enums.HostValidationStatus.HasActiveHostingUnits:
                        break;
                    case Enums.HostValidationStatus.Faild:
                        ErrorMessage =" שגיאת מסד";
                        break;
                    default:
                        break;
                }
                MessageBox.Show(ErrorMessage, "שגיאה");
            }
            else { 
                BackToList();
            }
           
          
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
