using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vinyl_Flare.MVVM.Commands;
using Vinyl_Flare.MVVM.Store;

namespace Vinyl_Flare.MVVM.ViewModel
{
    internal class SuccessViewModel : ViewModelBase
    {

        public ICommand NavigateFactoryCommand { get; }

        public SuccessViewModel(NavigationStore navigationStore)
        {
            NavigateFactoryCommand = new NavigateCommand<FactoryViewModel>(navigationStore, () => new FactoryViewModel(navigationStore));
        }



    }
}
