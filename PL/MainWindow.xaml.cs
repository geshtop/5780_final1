using BE;
using BL;
using PL.Pages;
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


namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

            ToHome();
            OwnerId = 0;
            RefreshAuthControls();
           
        }
        private Enums.AuthPermission auth = Enums.AuthPermission.Guest;
        public Enums.AuthPermission Auth
        {
            get
            {
                return auth;
            }
            set
            {
                auth = value;
                RefreshAuthControls();

            }
        }

        private void RefreshAuthControls()
        {
            AdminMenu.Visibility = System.Windows.Visibility.Hidden;
            OwnerMenu.Visibility = System.Windows.Visibility.Hidden;
            GuestMenu.Visibility = System.Windows.Visibility.Hidden;
            switch (Auth)
            {
                case Enums.AuthPermission.Guest:
                    GuestMenu.Visibility = System.Windows.Visibility.Visible;
                    break;
                case Enums.AuthPermission.Host:
                    OwnerMenu.Visibility = System.Windows.Visibility.Visible;
                    break;
                case Enums.AuthPermission.Admin:
                    AdminMenu.Visibility = System.Windows.Visibility.Visible;
                    break;
                default:
                    break;
            }

            BuildSide();
        }

        public int OwnerId { get; set; }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ToHome()
        {
            Pages.Main main = new Pages.Main();
            MainFrame.Content = main;
        }

        private void BuildSide()
        {

            Login login = new Login();
            SideFrame.Content = login;
        }

        
        private void Home_Click(object sender, RoutedEventArgs e)
        {

            ToHome();


        }
        private void Contact_Click(object sender, RoutedEventArgs e)
        {

            Contact contactPage = new Contact();
            MainFrame.Content = contactPage;


        }
        
        private void ApprovedAccount_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("בפיתוח");
        }
        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("בפיתוח");
        }
        private void AddReqest_Click(object sender, RoutedEventArgs e)
        {
            //check your logic
            Pages.EditGuestRequest requestPage = new Pages.EditGuestRequest();
            MainFrame.Content = requestPage;
            

        }
         

        private void ManageHosts_Click(object sender, RoutedEventArgs e)
        {

            HostList hostListPage = new HostList();
            MainFrame.Content = hostListPage;
           

        }

        private void AddHost_Click(object sender, RoutedEventArgs e)
        {

            EditHost hostPage = new EditHost(new Host());
            MainFrame.Content = hostPage;



        }
        private void RequestList_Click(object sender, RoutedEventArgs e)
        {
            if(OwnerId > 0){
                Pages.GuestRequestList requestList = new Pages.GuestRequestList();
                MainFrame.Content = requestList;

            }
            else
            {
                MessageBox.Show("יש לבחור מארח ");
            }
        }
      
        public  System.Windows.Visibility getVisible(){
             return System.Windows.Visibility.Hidden;

         }

       
    }
}
