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
           
        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ToHome()
        {
            Pages.Main main = new Pages.Main();
            MainFrame.Content = main;
        }
        private void Home_Click(object sender, RoutedEventArgs e)
        {

            ToHome();


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
      

       
    }
}
