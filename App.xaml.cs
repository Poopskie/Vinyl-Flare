using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        
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
