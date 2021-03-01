using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for OrderFinishedCard.xaml
    /// </summary>
    public partial class OrderFinishedCard
    {
        public OrderFinishedCard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
