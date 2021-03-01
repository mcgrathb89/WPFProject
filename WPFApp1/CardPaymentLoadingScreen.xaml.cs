using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPFApp1
{
    /// <summary>
    /// Interaction logic for CardPaymentLoadingScreen.xaml
    /// </summary>
    public partial class CardPaymentLoadingScreen : UserControl
    {
        DispatcherTimer timer = new DispatcherTimer();
        public CardPaymentLoadingScreen()
        {
            InitializeComponent();
            timer.Tick += Loader;
            timer.Interval = new TimeSpan(0, 0, 10);
            timer.Start();
        }

        public void Loader(object sender, EventArgs e)
        {
            Switcher.Switch(new OrderFinishedCard());
            timer.Stop();
        }
    }
}
