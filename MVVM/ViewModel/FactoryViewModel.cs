using NavigationMVVM.ViewModels;
using System;
using System.Windows.Input;
using Vinyl_Flare.Core;
using Vinyl_Flare.MVVM.Commands;
using Vinyl_Flare.MVVM.Service;
using Vinyl_Flare.MVVM.Store;

namespace Vinyl_Flare.MVVM.ViewModel // this was a good attempt, but in the end didn't work
{
    public class FactoryViewModel: ViewModelBase
    {
        public ICommand ShowSuccessCommand { get; }
        public ICommand CreateAlbumCommand { get;  }

        public FactoryViewModel(NavigationStore navigationStore)
        {
            // old function that did not send data of album
           // ShowSuccessCommand = new NavigateCommand<SuccessViewModel>(new NavigationService<SuccessViewModel>(
             //   navigationStore, () => new SuccessViewModel(navigationStore)));

            // call back function () =>
            ParameterNavigationService<Album, SuccessViewModel> navigationService = new ParameterNavigationService<Album, SuccessViewModel>(
                navigationStore, (parameter) => new SuccessViewModel(parameter, navigationStore));

            // CreateAlbumCommand uses navigationservice, which is right above, it is going to take the parameter from factory view model and pass it on
            CreateAlbumCommand = new CreateAlbumCommand(this, navigationService);


        }


    }
}
