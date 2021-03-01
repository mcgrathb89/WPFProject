using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for FinishOrder.xaml
    /// </summary>
    public partial class FinishOrder
    {
        public FinishOrder()
        {
            InitializeComponent();
        }

        private void NextOptionsButton_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PaymentType());
        }

        private void BackOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CardPaymentLoadingScreen());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
