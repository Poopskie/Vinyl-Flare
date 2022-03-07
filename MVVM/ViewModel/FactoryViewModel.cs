using System;
using Vinyl_Flare.Core;

namespace Vinyl_Flare.MVVM.ViewModel // this was a good attempt, but in the end didn't work
{
    internal class FactoryViewModel: Observable_Object
    {
        /*
        public RelayCommand SuccessViewCommand { get; set; }
        public SuccessViewModel SuccessVm { get; set; }
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

        public FactoryViewModel()
        {
            SuccessVm = new SuccessViewModel();
            FactoryVm = new FactoryViewModel();
            CurrentView = FactoryVm;

            SuccessViewCommand = new RelayCommand(o =>
            {
              //  currentView = SuccessVm;
            });
        }
        */

    }
}
