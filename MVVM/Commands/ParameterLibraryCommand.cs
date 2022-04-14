using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinyl_Flare.MVVM.Service;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    public class ParameterLibraryCommand : CommandBase
    {
        private readonly MainViewModel _viewModel;
        private readonly ParameterNavigationService<List<Album>, LibraryViewModel> _navigationService;

        public ParameterLibraryCommand(MainViewModel viewModel, ParameterNavigationService<List<Album>, LibraryViewModel> navigationService)
        {
            _viewModel = viewModel;
            _navigationService = navigationService;
        }
        public override void Execute(object parameter)
        {
            List<Album> albums = _viewModel.albums;

            _navigationService.Navigate(albums); // movin over to library viewmodel


        }
    }
}
