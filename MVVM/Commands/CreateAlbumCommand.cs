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
        private readonly ParameterNavigationService<Album, SuccessViewModel> _navigationService;
        public int newID;

        public CreateAlbumCommand(FactoryViewModel viewModel, ParameterNavigationService<Album, SuccessViewModel> navigationService)
        {
            _viewModel = viewModel;
            _navigationService = navigationService;
        }

        // IMPORTANT: Command will piece together all existing info in the viewmodel
        public override void Execute(object parameter)
        {
     //       using (var db = new AlbumContext())
     //       {
    //            newID = db.Albums.Count() + 1; // getting # of albums from database
    //        } ALBUM ID WILL AUTOMATICALLY BE SET

            Album album = new Album()
            {
      //          AlbumId = newID, // replace with db.album.count + 1
                AlbumName = $"{_viewModel.AlbumName}",
                Songs = _viewModel.SongArray,
                AlbumCoverURL = _viewModel._albumCover
            };

            // taking parameter from FactoryViewModel


            // then navigate to success after validating other details

            // Navigate with ParameterNavigationService + takes in a Tparameter
            _navigationService.Navigate(album);

        }
    }
}
