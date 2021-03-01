using System.Diagnostics;
using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for Feedback.xaml
    /// </summary>
    public partial class Feedback
    {
        public Feedback()
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("mailto:mcgrathb89@gmail.com?subject=Enquiry=BodyExample ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new About());
        }
    }
}
