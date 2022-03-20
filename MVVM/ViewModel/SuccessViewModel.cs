using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vinyl_Flare.MVVM.Commands;
using Vinyl_Flare.MVVM.Service;
using Vinyl_Flare.MVVM.Store;

namespace Vinyl_Flare.MVVM.ViewModel
{
    public class SuccessViewModel : ViewModelBase
    {

        // This is the view model that I will use to process data from Factory
        // I will input data into data base while showing loading screen
        // add to db -> finish loading -> show success

        // 2 buttons, back to factory, and back to home (side bar won't be here when success is up)

        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateFactoryCommand { get; }

        private Album _album { get; } // private album info recieved
        // use this variable to call on information recieved from factory

        public SuccessViewModel(Album album, NavigationStore navigationStore)
        {
            NavigateFactoryCommand = new NavigateCommand<FactoryViewModel>(new NavigationService<FactoryViewModel>(
                navigationStore, () => new FactoryViewModel(navigationStore)));

            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(new NavigationService<HomeViewModel>
                (navigationStore, () => new HomeViewModel()));

            _album = album;
        }



    }
}
