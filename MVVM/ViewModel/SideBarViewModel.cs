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
    public class SideBarViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLibraryCommand { get; }
        public ICommand NavigateFactoryCommand { get; }


        public SideBarViewModel(NavigationStore navigationStore)
        {

            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(new NavigationService<HomeViewModel>(
                navigationStore, () => new HomeViewModel()));

            NavigateLibraryCommand = new NavigateCommand<LibraryViewModel>(new NavigationService<LibraryViewModel>(
                navigationStore, () => new LibraryViewModel(navigationStore)));

            NavigateFactoryCommand = new NavigateCommand<FactoryViewModel>(new NavigationService<FactoryViewModel>(
                navigationStore, () => new FactoryViewModel(navigationStore)));


        }


    }
}
