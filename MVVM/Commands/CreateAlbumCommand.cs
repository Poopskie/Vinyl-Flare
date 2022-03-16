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
    public class CreateAlbumCommand : CommandBase
    {
        private readonly FactoryViewModel _viewModel; // current viewmodel information
        private readonly ParameterNavigationService<Album, LibraryViewModel> _navigationService;

        public CreateAlbumCommand(FactoryViewModel viewModel, ParameterNavigationService<Album, LibraryViewModel> navigationService)
        {
            _viewModel = viewModel;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            // taking parameter from FactoryViewModel
            Album album = new Album()
            {
                AlbumId = 1 // taking data from current viewmodel
                AlbumName = $"{_viewModel.AlbumName}"
                //Songs = 
                Image = $"{_viewModel.ImageLink}"
            };


            // then navigate to success after validating other details

            // Navigate from ParameterNavigationService takes in a Tparameter
            _navigationService.Navigate(album);

        }
    }
}
