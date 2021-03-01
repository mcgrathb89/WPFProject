using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for FinaliseBooking.xaml
    /// </summary>
    public partial class FinaliseBooking : UserControl
    {
        public FinaliseBooking()
        {
            InitializeComponent();
            TextBoxChosenFilm.Text = GlobalVariables.FilmName;
            TextBoxFilmTimes.Text = GlobalVariables.FilmTime;
            TextBoxTotalCost.Text = "£"+ Convert.ToString(GlobalVariables.TotalPrice, CultureInfo.InvariantCulture);
            TextBoxSeats.Text = GlobalVariables.SeatChoice;
            TextBoxType.Text = "x " + GlobalVariables.SelectedAmount + " " + GlobalVariables.TicketType;
            TextBoxDay.Text = GlobalVariables.FilmDay; 
        }

        private void NextOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ReservedFilm());
        }

        private void BackOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PaymentType());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
