using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace epicRD.Style
{
    partial class Window : ResourceDictionary
    {
        public Window()
        {
            InitializeComponent();
        }
        private void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            var window = (System.Windows.Window)((FrameworkElement)sender).TemplatedParent;
            window.WindowState = WindowState.Minimized;
        }
        private void MaximizeRestoreButton_OnClick(object sender, RoutedEventArgs e)
        {
            var window = (System.Windows.Window)((FrameworkElement)sender).TemplatedParent;
            window.WindowState = window.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }
        private void ExitButton_OnClick(object sender, RoutedEventArgs e)
        {
            var window = (System.Windows.Window)((FrameworkElement)sender).TemplatedParent;
            window.Close();
        }
    }
}
