using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for JohnWick2.xaml
    /// </summary>
    public partial class JohnWick2
    {
        public JohnWick2()
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
