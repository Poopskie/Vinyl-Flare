using System;
using Vinyl_Flare.Core;

namespace Vinyl_Flare.MVVM.ViewModel
{

    internal class MainViewModel : Observable_Object // always showing, calls upon other views
    {
        //old stuff that doesn't use the store

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand LibraryViewCommand { get; set; }
        public RelayCommand FactoryViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public LibraryViewModel LibraryVm { get; set; }
        public FactoryViewModel FactoryVm { get; set; }

        private object _currentView;


        public object CurrentView // current view object
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            // constructing default variables, declaration
            HomeVm = new HomeViewModel();
            LibraryVm = new LibraryViewModel();
            FactoryVm = new FactoryViewModel();

            CurrentView = HomeVm;

            // Commands to switch tabs
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            LibraryViewCommand = new RelayCommand(o =>
            {
                CurrentView = LibraryVm;
            });

            FactoryViewCommand = new RelayCommand(o =>
            {
                CurrentView = FactoryVm;
            });


        }
    }
}
