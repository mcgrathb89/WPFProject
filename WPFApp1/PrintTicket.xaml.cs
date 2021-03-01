using System.Windows;
using System.Windows.Input;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for PrintTicket.xaml
    /// </summary>
    public partial class PrintTicket
    {
        public PrintTicket()
        {
            InitializeComponent(); 
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new FinishOrder());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraCodeLoadingScreen());
        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.Switch(new OrderFinishedCard());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
