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

namespace Vinyl_Flare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Does not display without
        }
        // Toggle Button Commands for fullscreen
        private void btnFullScreen_Checked(object sender, RoutedEventArgs e)
        {
            window.WindowStyle = WindowStyle.None;
            window.WindowState = WindowState.Maximized;

        }

        private void btnFullScreen_Unchecked(object sender, RoutedEventArgs e)
        {
            window.WindowStyle = WindowStyle.ThreeDBorderWindow;
            window.WindowState = WindowState.Maximized;
            
        }
        // Toggle Button commands for hiding menus
        private void HideMenus_Checked(object sender, RoutedEventArgs e)
        {
            SideMenu.Visibility = Visibility.Hidden;
            btnFullScreen.Visibility = Visibility.Hidden;

        }

        private void HideMenus_Unchecked(object sender, RoutedEventArgs e)
        {
            SideMenu.Visibility = Visibility.Visible;
            btnFullScreen.Visibility = Visibility.Visible;
        }

        private void OnTargetUpdated(object sender, DataTransferEventArgs e)
        { // When the ViewModel changes

            // if current view model == playsongviewmodel then hide everything & display new
            if (milim.Visibility == Visibility.Visible)
            {
                HideMenus.Visibility = Visibility.Hidden;
                SideMenu.Visibility = Visibility.Hidden;
                btnFullScreen.Visibility = Visibility.Hidden;
                window.WindowStyle = WindowStyle.None;

            }
            else
            {
                HideMenus.Visibility = Visibility.Visible;
                SideMenu.Visibility = Visibility.Visible;
                btnFullScreen.Visibility = Visibility.Visible;
                window.WindowStyle = WindowStyle.None;

            }

        }
    }
}
