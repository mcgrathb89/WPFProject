using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for FinaliseCashPayment.xaml
    /// </summary>
    public partial class FinaliseCashPayment : UserControl
    {
        public FinaliseCashPayment()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
