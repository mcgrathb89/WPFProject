using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for GamePlay.xaml
    /// </summary>
    public partial class Booking
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void backButton_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void BookFilmButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CreateBooking());
        }

        private void BookExtraButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Extras());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PaymentType());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void Ellipse_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Switcher.Switch(new PaymentType());
        }

        private void TextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Switcher.Switch(new PaymentType());
        }

    }
}
