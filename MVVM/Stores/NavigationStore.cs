using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Store
{
    public class NavigationStore
    {
        // action is void event with no parameters
        public event Action CurrentViewModelChanged;
        // action for playsongviewmodel
        public event Action PlayingSongsNow;

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set 
            { 
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            if (_currentViewModel.GetType() == typeof(PlaySongViewModel))
            {
                PlayingSongsNow?.Invoke();
            }

            // method that notifies all subscribed to currentviewmodelchanged
            CurrentViewModelChanged?.Invoke();

        }
    }
}
