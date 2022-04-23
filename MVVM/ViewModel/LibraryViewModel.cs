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

        public List<Album> albums { get; } // need the albums here to display them
        public int selected; // changes as clicked

        public ICommand PlaySongCommand0 { get; }

        public Album album1 { get; set; }


        public LibraryViewModel(NavigationStore navigationStore, List<Album> albumsIn = null)
        {

            ParameterNavigationService<Album, PlaySongViewModel> navigationService = new ParameterNavigationService<Album, PlaySongViewModel>(
                navigationStore, (parameter) => new PlaySongViewModel(parameter));

            albums = albumsIn;

            PlaySongCommand0 = new PlaySongCommand(this, navigationService, 8);






        }



    }
}
