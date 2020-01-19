using BE;
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
    /// Interaction logic for EditUnitHost.xaml
    /// </summary>
    public partial class EditUnitHost : PageBase
    {
        protected HostingUnit CurrentHU { get; set; }
        public EditUnitHost(int id = 0)
        {
            string[] months = new string[]{ "ינו", "פבר", "מרץ", "אפר", "מאי", "יונ", "יול", "אוג", "ספט", "אוק", "נוב", "דצמ" };
            if (id > 0)
            {

            }
            else
            {
                CurrentHU = new HostingUnit();
            }
            InitializeComponent();
            hostEditGrid.DataContext = CurrentHU;
            for (int i = 0; i <= 31; i++)
            {
                calendarGrid.ColumnDefinitions.Add(new ColumnDefinition());
                

            }
            for (int i = 0; i < 12; i++)
            {

                calendarGrid.RowDefinitions.Add(new RowDefinition());
                Label l = new Label();
                l.Content = months[i];
                calendarGrid.Children.Add(l);
                Grid.SetRow(l, i);
                Grid.SetColumn(l, 0);
            }
        

            for (DateTime date = new DateTime(2020, 1,1); date <  new DateTime(2021, 1,1); date = date.AddDays(1))
            {
                Label l = new Label();
                l.Content = date.ToString("dd");
                calendarGrid.Children.Add(l);
                Grid.SetRow(l, date.Month -1);
                Grid.SetColumn(l, date.Day );

                if (CurrentHU.DiaryState.Calender[date.Month - 1, date.Day - 1])
                {
                    l.Foreground = new SolidColorBrush(Colors.Blue);
                }
                else
                {
                    l.Foreground = new SolidColorBrush(Colors.Gray);
                }

            }

        }


        private void ShowPanel_Click(object sender, RoutedEventArgs e)
        {


            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    hostEditGrid.Visibility = System.Windows.Visibility.Visible;
                    calendarGrid.Visibility = System.Windows.Visibility.Hidden;
                    break;
                case 1:
                    hostEditGrid.Visibility = System.Windows.Visibility.Hidden;
                    calendarGrid.Visibility = System.Windows.Visibility.Visible;
                    break;
                case 2:

                    break;

            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

            app.AddHostingUnit(CurrentHU);

        }



    }
}
