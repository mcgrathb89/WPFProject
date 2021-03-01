using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for ShowingTimes.xaml
    /// </summary>
    public partial class ShowingTimes
    {
        public ShowingTimes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Showings());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
