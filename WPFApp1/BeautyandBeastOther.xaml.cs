using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for OptionsMenu.xaml
    /// </summary>
    public partial class BeautyandBeastOther : UserControl
    {
        public BeautyandBeastOther()
        {
            InitializeComponent();
        }

        private void backOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Showings());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MediaElementPlayer.LoadedBehavior = MediaState.Play;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MediaElementPlayer.LoadedBehavior = MediaState.Stop;
            MediaElementPlayer.UnloadedBehavior = MediaState.Stop;
        }

        private void MediaElementPlayer_OnLoaded(object sender, RoutedEventArgs e)
        {
            MediaElementPlayer.Play();
            MediaElementPlayer.Pause();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MediaElementPlayer.LoadedBehavior = MediaState.Pause;
        }
    }
}
