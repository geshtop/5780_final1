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
        //bool flag = false;
        public Contact()
        {
            InitializeComponent();
            //flag = true;
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
               string text = "שם: " + name.Text + "\nמייל: " + telephon.Text
                + "\nגוף ההודעה: " + TxtBody.Text;
               try
               {
                   app.SendMail("", "rivkistudies@gmail.com", "GS פנייה: " +  TxtSubject.Text, text, false);
                   MessageBox.Show("המייל נשלח בהצלחה");
                   BackToMain();// חזרה לדף ראשי
               }
               catch
               {
                   MessageBox.Show("אירעה בעיה במשלוח המייל");
               }
              
         
            
        }
    }
}
