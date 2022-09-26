using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
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

        private List<ICommand> _playSongCommands = new List<ICommand>();
        public List<ICommand> PlaySongCommands { get => _playSongCommands; }


        public int pageValue = 0;

        // nasty repetitive code cuz i suck at coding

        private List<Album> _albumDisplay = new List<Album>();
        public List<Album> AlbumDisplay 
        { 
            get => _albumDisplay;
            set
            {
                _albumDisplay = value;
            }
        }

        public ICommand NextPageICommand { get; set; }
        public ICommand LastPageICommand { get; set; }
        private ParameterNavigationService<Album, PlaySongViewModel> navigationService;
        private ICommand TempPlaySongCommand;


        public LibraryViewModel(NavigationStore navigationStore, List<Album> albumsIn = null)
        {

            navigationService = new ParameterNavigationService<Album, PlaySongViewModel>(
                navigationStore, (parameter) => new PlaySongViewModel(parameter));

            albums = albumsIn;

            NextPageICommand = new LibraryPageCommand(this, pageValue, "next");
            LastPageICommand = new LibraryPageCommand(this, pageValue, "last");

            for (int i = pageValue; i < pageValue+4; i++)
                {
                    try
                    {
                        _albumDisplay.Add(albums[i]); // add first 4 albums
                        TempPlaySongCommand = new PlaySongCommand(this, navigationService, i);
                         _playSongCommands.Add(TempPlaySongCommand); // copying above

                    } catch (ArgumentOutOfRangeException)
                       {
                         break;
                       } // catch index error
                }

        }



        public void NextPageCommand()
        {
            pageValue += 4;
            // swapping up
            _albumDisplay.Clear();
            _playSongCommands.Clear();
            for (int i = pageValue; i < pageValue + 4; i++)
            {
                try
                {
                    _albumDisplay.Add(albums[i]); // add first 4 albums
                    TempPlaySongCommand = new PlaySongCommand(this, navigationService, i);
                    _playSongCommands.Add(TempPlaySongCommand); // copying above

                }
                catch (ArgumentOutOfRangeException)
                {
                    break;
                } // catch index error
            }
            OnAlbumDisplayPropertyChanged();
            OnPlaySongCommandPropertyChanged();

        }

        public void LastPageCommand()
        {
            if (pageValue > 0)
            {
                pageValue -= 4;
            }
            
            // swapping up
            _albumDisplay.Clear();
            _playSongCommands.Clear();
            for (int i = pageValue; i < pageValue + 4; i++)
            {
                try
                {
                    _albumDisplay.Add(albums[i]); // add first 4 albums
                    TempPlaySongCommand = new PlaySongCommand(this, navigationService, i);
                    _playSongCommands.Add(TempPlaySongCommand); // copying above

                }
                catch (ArgumentOutOfRangeException)
                {
                    break;
                } // catch index error
            }
            OnAlbumDisplayPropertyChanged();
            OnPlaySongCommandPropertyChanged();
        }

        private void OnAlbumDisplayPropertyChanged()
        {
            OnPropertyChanged(nameof(AlbumDisplay));
        }
        private void OnPlaySongCommandPropertyChanged()
        {
            OnPropertyChanged(nameof(PlaySongCommands));
        }


    }
}
