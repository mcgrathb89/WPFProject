using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for PiratesoftheCaribbean5.xaml
    /// </summary>
    public partial class PiratesoftheCaribbean5
    {
        public PiratesoftheCaribbean5()
        {
            InitializeComponent();
        }

        private void BackOptionsButton_OnClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
