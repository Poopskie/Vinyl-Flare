using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Vinyl_Flare.MVVM.Store;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare
{
    /// <summary>
    ///
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {

            NavigationStore navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new HomeViewModel();

            SideBarViewModel sideBarViewModel = new SideBarViewModel(navigationStore);

            // This is not displaying the MainWindow, at all...
            // but i need it to use mainviewmodel as a datacontext
            MainWindow mainWindow = new()
            {
                 DataContext = new MainViewModel(navigationStore, sideBarViewModel)
            };

            mainWindow.Show();
            
            base.OnStartup(e);
        }





        

        //thing i added for routedevent, remove later no kizzy
        private RoutedEvent isSpinning;

        public RoutedEvent GetIsSpinning()
        {
            return isSpinning;
        }

        public void SetIsSpinning(RoutedEvent value)
        {
            isSpinning = value;
        }

    }

}
