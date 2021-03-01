using System.Globalization;
using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for ExtraTicket.xaml
    /// </summary>
    public partial class ExtraTicket 
    {
        public ExtraTicket()
        {
            InitializeComponent();
            TextBoxExtra.Text = GlobalVariables.StoreExtraName;
            //TextBoxExtraTotal.Text = GlobalVariables.TotalExtraCost.ToString(CultureInfo.InvariantCulture);
        }

        private void NextOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Extras());
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraCodeLoadingScreen());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
