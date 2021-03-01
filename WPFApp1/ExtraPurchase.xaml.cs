using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for ExtraPurchase.xaml
    /// </summary>
    public partial class ExtraPurchase
    {
        public ExtraPurchase()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Extras());
        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.Switch(new Extras());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
