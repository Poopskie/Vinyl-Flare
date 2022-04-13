using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vinyl_Flare.MVVM.Commands;
using Vinyl_Flare.MVVM.Service;
using Vinyl_Flare.MVVM.Store;

namespace Vinyl_Flare.MVVM.ViewModel
{
    public class LibraryViewModel : ViewModelBase
    {

        //Used to be: public LibararyViewModel(Album album, NavigationStore navigationStore)
        // don't need to recieve album here, cuz we will simply add to database in the command.

        // need a way to display albums in the list
        // either have a counter for top 3 then switch
        // OR have a draggable row of albums to choose from

        public readonly List<Album> albums; // need the albums here to display them
        public int selected; // changes as clicked

        public ICommand PlaySongCommand0;

        public LibraryViewModel(NavigationStore navigationStore)
        {
            using (var db = new AlbumContext()) // using EF core to simplify syntax
            { // lambda b function, returns the albumid attribute of albums
                albums = db.Albums.ToList(); // returns list of all the albums
            }

            ParameterNavigationService<Album, HomeViewModel> navigationService = new ParameterNavigationService<Album, HomeViewModel>(
                navigationStore, (parameter) => new HomeViewModel(parameter));

            PlaySongCommand0 = new PlaySongCommand(this, navigationService, 0);

        }



    }
}
