using System.Windows;
using System.Windows.Input;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for TicketPrint.xaml
    /// </summary>
    public partial class TicketPrint
    {
        public TicketPrint()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Booking());
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.Switch(new Booking());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
