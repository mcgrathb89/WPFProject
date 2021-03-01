using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for Seats.xaml
    /// </summary>
    public partial class Seats
    {
        public Seats()
        {
            InitializeComponent();
        }

        private void BackOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
