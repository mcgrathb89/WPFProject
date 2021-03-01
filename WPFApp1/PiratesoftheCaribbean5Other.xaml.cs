using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for PiratesoftheCaribbean5.xaml
    /// </summary>
    public partial class PiratesoftheCaribbean5Other
    {
        public PiratesoftheCaribbean5Other()
        {
            InitializeComponent();
        }

        private void BackOptionsButton_OnClick(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Showings());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
        private void MediaElementPlayer_OnLoaded(object sender, RoutedEventArgs e)
        {
            MediaElementPlayer.Play();
            MediaElementPlayer.Pause();
        }

        private void backOptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Showings());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MediaElementPlayer.LoadedBehavior = MediaState.Play;
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
