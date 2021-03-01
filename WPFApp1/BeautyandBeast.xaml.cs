using System.Windows;
using System.Windows.Controls;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for OptionsMenu.xaml
    /// </summary>
    public partial class BeautyandBeast : UserControl
    {
        public BeautyandBeast()
        {
            InitializeComponent();
        }

        private void backOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
