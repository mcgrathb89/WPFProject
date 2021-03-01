using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for CreateBooking.xaml
    /// </summary>
    public partial class CreateBooking : UserControl
    {
        public static List<string> TicketType { get; set; }

        public CreateBooking()
        {
            InitializeComponent();
        }

        private void NextOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            decimal adultQuantity;
            decimal childQuantity;
            decimal concessionQuantity;
            decimal studentQuantity;
            decimal adultTotal = 0;
            decimal childTotal = 0;
            decimal concessionTotal = 0;
            decimal studentTotal = 0;

            if (TextBoxAdultTicket.Text != String.Empty)
            {
                adultQuantity = Convert.ToInt32(TextBoxAdultTicket.Text);
                GlobalVariables.SelectedAmount = TextBoxAdultTicket.Text;
                adultTotal = GlobalVariables.AdultPrice * adultQuantity;
                GlobalVariables.TicketType = " Adult";
            }

            if (TextBoxChildTicket.Text != String.Empty)
            {
                childQuantity = Convert.ToInt32(TextBoxChildTicket.Text);
                GlobalVariables.SelectedAmount = TextBoxChildTicket.Text;
                childTotal = GlobalVariables.ChildPrice * childQuantity;
                GlobalVariables.TicketType = " Child";
            }

            if (TextBoxConcessionTicket.Text != String.Empty)
            {
                concessionQuantity = Convert.ToInt32(TextBoxConcessionTicket.Text);
                GlobalVariables.SelectedAmount = TextBoxConcessionTicket.Text;
                concessionTotal = GlobalVariables.ConcessionPrice * concessionQuantity;
                GlobalVariables.TicketType = " Concession";
            }

            if (TextBoxStudentTicket.Text != String.Empty)
            {
                studentQuantity = Convert.ToInt32(TextBoxStudentTicket.Text);
                GlobalVariables.SelectedAmount = TextBoxStudentTicket.Text;
                studentTotal = GlobalVariables.StudentPrice * studentQuantity;
                GlobalVariables.TicketType = " Student";
            }

            GlobalVariables.TotalPrice = adultTotal + childTotal + concessionTotal + studentTotal;
            Switcher.Switch(new ReservedFilm());
        }

        private void BackOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Booking());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmName = "Beauty and the Beast";
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmName = "John Wick 2";
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmName = "Dunkirk";
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmName = "Pirates of the Caribbean 5";
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTime = "12:00PM";
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTime = "3:00PM";
        }

        private void ListBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTime = "7:00PM";
        }

        private void ListBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTime = "10:00PM";
        }

        private void ListBoxItem_Selected_9(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmTime = "9:00AM";
        }

        private void ListBoxItem_Selected_8(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmDay = "Monday";
        }

        private void ListBoxItem_Selected_10(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmDay = "Tuesday";
        }

        private void ListBoxItem_Selected_11(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmDay = "Wednesday";
        }

        private void ListBoxItem_Selected_12(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmDay = "Thursday";
        }

        private void ListBoxItem_Selected_13(object sender, RoutedEventArgs e)
        {
            GlobalVariables.FilmDay = "Friday"; 
        }
    }
}
