using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinyl_Flare.MVVM.Service;
using Vinyl_Flare.MVVM.Store;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    internal class NavigateCommand<TViewModel> : CommandBase
        // contrainging and making sure TViewModel is view model base
        where TViewModel : ViewModelBase
    {
        private readonly NavigationService<TViewModel> _navigationService;

        // re-did navigation command to run the function in the service
        public NavigateCommand(NavigationService<TViewModel> navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
