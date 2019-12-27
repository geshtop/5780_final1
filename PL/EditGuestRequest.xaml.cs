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
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for EditGuestRequest.xaml
    /// </summary>
    public partial class EditGuestRequest : Window
    {
        private AppLogic app { get; set; }
        public GuestRequest CurrRequest { get; set; }
        public List<string> PhonePreList { get; set; }
        public EditGuestRequest(AppLogic _app)
        {
            CurrRequest = new GuestRequest();
            this.app = _app;
            PhonePreList = app.GetPrePhones();
            InitializeComponent();
            GuestRequestGrid.DataContext = CurrRequest;
            prePhoneCb.ItemsSource = PhonePreList;



        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var state = Enums.GuestRequesteCreateStatus.Success;
            app.AddGusetRequest(CurrRequest, out state);

            if (state != Enums.GuestRequesteCreateStatus.Success)
            {
                string ErrorMessage = "";
                switch (state)
                {
                    case Enums.GuestRequesteCreateStatus.MissingFields:
                        ErrorMessage = "יש למלא שדות חובה";
                        break;
                    case Enums.GuestRequesteCreateStatus.WrongFields:
                        ErrorMessage = "מבנה שדות שגויים";
                        break;
                    case Enums.GuestRequesteCreateStatus.ErrorDates:
                        ErrorMessage = "יש לבדוק תאריכים";
                        break;
                    case Enums.GuestRequesteCreateStatus.NoHosting:
                        ErrorMessage = "המערכת לא מצאה יחידות אירוח מתאימים לתאריכים שצויינו, נסה בתאריכים נוספים";
                        break;
                    case Enums.GuestRequesteCreateStatus.Success:
                        break;
                    default:
                        break;
                }


                MessageBox.Show(ErrorMessage, "שגיאה");
            }
            else
            {

                MessageBox.Show("תודה רבה, בקשתך נקלטה במערכת", "הודעת מערכת");
                BackToList();
            }


        }


        private void BackToList_Click(object sender, RoutedEventArgs e)
        {


            BackToList();

        }



        private void BackToList()
        {
            this.Close();
           // HostList hostListPage = new HostList(this.app);
           // hostListPage.ShowDialog();

        }
    }
}
