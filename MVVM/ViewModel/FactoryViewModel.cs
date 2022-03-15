using NavigationMVVM.ViewModels;
using System;
using System.Windows.Input;
using Vinyl_Flare.Core;
using Vinyl_Flare.MVVM.Commands;
using Vinyl_Flare.MVVM.Store;

namespace Vinyl_Flare.MVVM.ViewModel // this was a good attempt, but in the end didn't work
{
    internal class FactoryViewModel: ViewModelBase
    {
        public ICommand ShowSuccessCommand { get; }

        public FactoryViewModel(NavigationStore navigationStore)
        {
            ShowSuccessCommand = new NavigateCommand<SuccessViewModel>(navigationStore, () => new SuccessViewModel(navigationStore));
        }

    }
}
