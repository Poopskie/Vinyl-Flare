using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Vinyl_Flare.Core;
using Vinyl_Flare.MVVM.Commands;
using Vinyl_Flare.MVVM.Service;
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
        public ICommand NavigateLibraryCommand { get; } // property with parameter
        public ICommand NavigateFactoryCommand => SideBar.NavigateFactoryCommand;

        public readonly List<Album> albums; // NEED TO ADD A ONPROPERTYCHANGED

        private readonly ParameterNavigationService<List<Album>, LibraryViewModel> _navigationService; // to library

        public MainViewModel(NavigationStore navigationStore, SideBarViewModel sideBarViewModel)
        {
            using (var db = new AlbumContext()) // using EF core to simplify syntax
            { // lambda b function, returns the albumid attribute of albums
                albums = db.Albums.ToList(); // returns list of all the albums
            }

            ParameterNavigationService<List<Album>, LibraryViewModel> navigationService = new ParameterNavigationService<List<Album>, LibraryViewModel>(
                navigationStore, (parameter) => new LibraryViewModel(navigationStore, parameter));

            _navigationService = navigationService; // to send List<Album> to library
            NavigateLibraryCommand = new ParameterLibraryCommand(this, navigationService); // making library command

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