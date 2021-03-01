using System.Windows;
using System.Windows.Input;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for PrintCashTicket.xaml
    /// </summary>
    public partial class PrintCashTicket
    {
        public PrintCashTicket()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PaymentType());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CashPaymentLoadingScreen());
        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.Switch(new CashPaymentLoadingScreen()); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
