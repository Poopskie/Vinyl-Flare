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
        private readonly ParameterNavigationService<Album, PlaySongViewModel> _navigationService;
        private readonly int _selected;

        public PlaySongCommand(LibraryViewModel viewModel, ParameterNavigationService<Album, PlaySongViewModel> navigationService,
            int selected)
        {
            _viewModel = viewModel;
            _navigationService = navigationService;
            _selected = selected;
        }

        public override void Execute(object parameter)
        {
            // taking parameter from Libraryviewmodel (which has album<list> from db)
            Album album = _viewModel.albums[_selected];
            
            // Navigate the selected album to home

            // Navigate with ParameterNavigationService + takes in a Tparameter
            _navigationService.Navigate(album);

        }
    }
}
