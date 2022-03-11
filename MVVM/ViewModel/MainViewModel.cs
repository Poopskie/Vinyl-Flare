using NavigationMVVM.ViewModels;
using System;
using Vinyl_Flare.Core;
using Vinyl_Flare.MVVM.Store;

namespace Vinyl_Flare.MVVM.ViewModel
{

    internal class MainViewModel : ViewModelBase // always showing, calls upon other views
    {
        //all the new stuff for MVVM
        private readonly NavigationStore _navigationStore;

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigationStore)
        {
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