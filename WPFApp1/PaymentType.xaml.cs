using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for PaymentType.xaml
    /// </summary>
    public partial class PaymentType
    {
        public PaymentType()
        {
            InitializeComponent();
        }

        private void BackOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new FinaliseBooking());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new FinishOrder());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PrintCashTicket());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
