using System.Linq;
using System.Windows;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for Extras.xaml
    /// </summary>
    public partial class Extras 
    {
        public Extras()
        {
            InitializeComponent();
        }

        private void NextOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Booking());
            //GlobalVariables.TotalExtraCost = GlobalVariables.StoreExtraCost.Sum();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Popcorn and Drink Deal: £8.00";
            //GlobalVariables.StoreExtraCost.Add(8.00m);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Hotdog: £3.00";
            //GlobalVariables.StoreExtraCost.Add(3.00m);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Icecream: £2.50";
            //GlobalVariables.StoreExtraCost.Add(2.50m);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Large Drink: £2.00";
            //GlobalVariables.StoreExtraCost.Add(2.00m);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Medium Drink: £1.50";
            //GlobalVariables.StoreExtraCost.Add(1.50m);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Small Drink: £1.00";
            //GlobalVariables.StoreExtraCost.Add(1.00m);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Large Popcorn: £5.00";
            //GlobalVariables.StoreExtraCost.Add(5.00m);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Medium Popcorn: £3.00";
            //GlobalVariables.StoreExtraCost.Add(3.00m);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Small Popcorn: £1.00";
            //GlobalVariables.StoreExtraCost.Add(1.00m);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Nachos: £2.50";
            //GlobalVariables.StoreExtraCost.Add(2.50m);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Bag of Sweets: £1.50";
            //GlobalVariables.StoreExtraCost.Add(1.50m);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraPurchase());
            GlobalVariables.StoreExtraName = "x 1 Pizza Slice: £3.00";
            //GlobalVariables.StoreExtraCost.Add(3.00m);
        }

        private void BackOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ExtraTicket());
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
