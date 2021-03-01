using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for ReservedFilm.xaml
    /// </summary>
    public partial class ReservedFilm
    {
        public ReservedFilm()
        {
            InitializeComponent();
            TextBoxFilm.Text = GlobalVariables.FilmName;
            TextBoxTime.Text = GlobalVariables.FilmTime;
            TextBoxTicketType.Text = "x " + GlobalVariables.SelectedAmount + GlobalVariables.TicketType;
            TextBoxDay.Text = GlobalVariables.FilmDay;
        }

        private void NextOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CreateBooking());
        }

        private void BackOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new FinaliseBooking());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "A1";
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "A2";
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "A3";
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "A4";
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "A5";
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "A6";
        }

        private void ListBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "A10";
        }

        private void ListBoxItem_Selected_7(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "B1";
        }

        private void ListBoxItem_Selected_8(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "B2";
        }

        private void ListBoxItem_Selected_9(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "B3";
        }

        private void ListBoxItem_Selected_10(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "B4";
        }

        private void ListBoxItem_Selected_11(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "B5";
        }

        private void ListBoxItem_Selected_12(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "B6";
        }

        private void ListBoxItem_Selected_13(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "B7";
        }

        private void ListBoxItem_Selected_14(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "B8";
        }

        private void ListBoxItem_Selected_15(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "B9";
        }

        private void ListBoxItem_Selected_16(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "B10";
        }

        private void ListBoxItem_Selected_17(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "C1";
        }

        private void ListBoxItem_Selected_18(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "C2";
        }

        private void ListBoxItem_Selected_19(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "C3";
        }

        private void ListBoxItem_Selected_20(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "C4";
        }

        private void ListBoxItem_Selected_21(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "C5";
        }

        private void ListBoxItem_Selected_22(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "C6";
        }

        private void ListBoxItem_Selected_23(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "C7";
        }

        private void ListBoxItem_Selected_24(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "C8";
        }

        private void ListBoxItem_Selected_25(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "C9";
        }

        private void ListBoxItem_Selected_26(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "C10";
        }

        private void ListBoxItem_Selected_27(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "D1";
        }

        private void ListBoxItem_Selected_28(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "D2";
        }

        private void ListBoxItem_Selected_29(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "D3";
        }

        private void ListBoxItem_Selected_30(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "D6";
        }

        private void ListBoxItem_Selected_31(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "D7";
        }

        private void ListBoxItem_Selected_32(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "D8";
        }

        private void ListBoxItem_Selected_33(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "D9";
        }

        private void ListBoxItem_Selected_34(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "D10";
        }

        private void ListBoxItem_Selected_35(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "E1";
        }

        private void ListBoxItem_Selected_36(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "E2";
        }

        private void ListBoxItem_Selected_37(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "E3";
        }

        private void ListBoxItem_Selected_38(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "E4";
        }

        private void ListBoxItem_Selected_39(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "E5";
        }

        private void ListBoxItem_Selected_40(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "E6";
        }

        private void ListBoxItem_Selected_41(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "E7";
        }

        private void ListBoxItem_Selected_42(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "E8";
        }

        private void ListBoxItem_Selected_43(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "E9";
        }

        private void ListBoxItem_Selected_44(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "E10";
        }

        private void ListBoxItem_Selected_45(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "F3";
        }

        private void ListBoxItem_Selected_46(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "F4";
        }

        private void ListBoxItem_Selected_47(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "F5";
        }

        private void ListBoxItem_Selected_48(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "F6";
        }

        private void ListBoxItem_Selected_49(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "F7";
        }

        private void ListBoxItem_Selected_50(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "F8";
        }

        private void ListBoxItem_Selected_51(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "F9";
        }

        private void ListBoxItem_Selected_52(object sender, RoutedEventArgs e)
        {
            GlobalVariables.SeatChoice = "F10";
        }
    }
}
