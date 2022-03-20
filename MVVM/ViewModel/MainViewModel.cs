using NavigationMVVM.ViewModels;
using System;
using Vinyl_Flare.Core;
using Vinyl_Flare.MVVM.Store;

namespace Vinyl_Flare.MVVM.ViewModel
{

    public class MainViewModel : ViewModelBase // always showing, calls upon other views
    {
        //all the new stuff for MVVM
        private readonly NavigationStore _navigationStore;
        private readonly SideBarViewModel SideBar;

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigationStore, SideBarViewModel sideBarViewModel)
        {
            SideBar = sideBarViewModel;
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

        }

        private void OnCurrentViewModelChanged()
        {
            // view regrabs the value of currentviewmodel
            OnPropertyChanged(nameof(CurrentViewModel));
            // going to go to viewmodelbase triggering "Inotifiedpropertychanged" 
        }
    }

}