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

namespace epicRD.Pages
{
    /// <summary>
    /// Interaction logic for PreparingToLaunchStore.xaml
    /// </summary>
    public partial class PreparingToLaunchStore : Page
    {
        readonly DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public PreparingToLaunchStore()
        {
            InitializeComponent();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            MainGrid.Height = 220;
            ProgressBar.Visibility = Visibility.Visible;

            dispatcherTimer.Tick += dispatcherTimer_Tick_1;
            dispatcherTimer.Stop();

            dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick_1(object sender, EventArgs e)
        {
            if ((Application.Current.MainWindow != null))
            {
                ((MainWindow)Application.Current.MainWindow).MainFrame.Navigate(new Uri("../Pages/StorePage.xaml", UriKind.RelativeOrAbsolute));
            }
            dispatcherTimer.Stop();
        }
    }
}
