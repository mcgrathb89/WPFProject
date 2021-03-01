using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for JohnWick2.xaml
    /// </summary>
    public partial class JohnWick2Other
    {
        public JohnWick2Other() 
        {
            InitializeComponent();
        }

        private void BackOptionsButton_Click(object sender, RoutedEventArgs e)
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
        private void MediaElementPlayer_OnLoaded(object sender, RoutedEventArgs e)
        {
            MediaElementPlayer.Play();
            MediaElementPlayer.Pause();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MediaElementPlayer.Position = TimeSpan.Zero;
            MediaElementPlayer.LoadedBehavior = MediaState.Stop;
            MediaElementPlayer.UnloadedBehavior = MediaState.Stop;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MediaElementPlayer.LoadedBehavior = MediaState.Pause;
        }
    }
}
