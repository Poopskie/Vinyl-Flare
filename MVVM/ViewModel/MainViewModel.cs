using NavigationMVVM.ViewModels;
using System;
using System.Windows.Input;
using Vinyl_Flare.Core;
using Vinyl_Flare.MVVM.Store;

namespace Vinyl_Flare.MVVM.ViewModel
{

    public class MainViewModel : ViewModelBase // always showing, calls upon other views
    {
        //all the new stuff for MVVM
        private readonly NavigationStore _navigationStore;
        private readonly SideBarViewModel SideBar;

        // points to the navigationstores view model
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;


        // taking out commands from sidebarviewmodel
        public ICommand NavigateHomeCommand => SideBar.NavigateHomeCommand;
        public ICommand NavigateLibraryCommand => SideBar.NavigateLibraryCommand;
        public ICommand NavigateFactoryCommand => SideBar.NavigateFactoryCommand;


        public MainViewModel(NavigationStore navigationStore, SideBarViewModel sideBarViewModel)
        {
            SideBar = sideBarViewModel;
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            // Once invoked, method added will be triggered

        }

        private void OnCurrentViewModelChanged()
        {
            // view regrabs the value of currentviewmodel
            OnPropertyChanged(nameof(CurrentViewModel));
            // going to go to viewmodelbase triggering "Inotifiedpropertychanged" 
        }
    }

}