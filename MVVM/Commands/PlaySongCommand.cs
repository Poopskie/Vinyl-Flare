using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Vinyl_Flare.MVVM.Service;
using Vinyl_Flare.MVVM.Store;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    public class PlaySongCommand : CommandBase // using a parameter navigation service
        // using this to move selected album to home to play
    {
        private readonly LibraryViewModel _viewModel; // current viewmodel information
        private readonly ParameterNavigationService<Album, HomeViewModel> _navigationService;
        private readonly int _selected;

        public PlaySongCommand(LibraryViewModel viewModel, ParameterNavigationService<Album, HomeViewModel> navigationService,
            int selected)
        {
            _viewModel = viewModel;
            _navigationService = navigationService;
            _selected = selected;
        }

        public override void Execute(object parameter)
        {
            // taking parameter from Libraryviewmodel (which queries)
            Album album = _viewModel.albums[_selected];
            


            // then navigate to success after validating other details

            // Navigate with ParameterNavigationService + takes in a Tparameter
            _navigationService.Navigate(album);

        }
    }
}
