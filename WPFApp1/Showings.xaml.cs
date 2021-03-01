using System.Windows;
using System.Windows.Input;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for LoadGame.xaml
    /// </summary>
    public partial class Showings
    {
        public Showings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ShowingTimes());
        }

        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new BeautyandBeastOther()); 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new DunkirkOther());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new JohnWick2Other());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PiratesoftheCaribbean5Other());
        }
    }
}
