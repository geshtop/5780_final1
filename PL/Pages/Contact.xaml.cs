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
    /// Interaction logic for Contact.xaml
    /// </summary>
    public partial class Contact : PageBase
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("חסר ביצוע השליחה");
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Telephon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
