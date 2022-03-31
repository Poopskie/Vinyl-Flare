﻿using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Vinyl_Flare.Core;
using Vinyl_Flare.MVVM.Commands;
using Vinyl_Flare.MVVM.Service;
using Vinyl_Flare.MVVM.Store;

namespace Vinyl_Flare.MVVM.ViewModel // this was a good attempt, but in the end didn't work
{
    public class FactoryViewModel: ViewModelBase
    {
        public ICommand ShowSuccessCommand { get; }
        public ICommand CreateAlbumCommand { get;  }
        public ICommand AddSongCommand { get; } // I NEED TO TEST THESE
        public ICommand AddImageCommand { get; }
        public ICommand RemoveSongCommand { get; }

        // update to display image selection
        private event Action ImagePropertyChanged;

        // IMPORTANT: name textboxes, refer to them here and add info into a variable

        public string AlbumName { get; set; }

        private BitmapImage _albumCover; // Basically working, value comes in, just need to notify
        public BitmapImage AlbumCover {
            get => _albumCover;
            set { 
                _albumCover = value;
                OnImagePropertyChanged(); // Trigger prop changed thing
            }
        } // path to image 

        private List<Song> _songArray; // private version
        public List<Song> SongArray // creating property to be accessed
        {
            get => _songArray;
            set
            {
                _songArray = value;
                OnSongArrayPropertyChanged();
            }
        }


        public FactoryViewModel(NavigationStore navigationStore)
        {
            // old function that did not send data of album
           // ShowSuccessCommand = new NavigateCommand<SuccessViewModel>(new NavigationService<SuccessViewModel>(
             //   navigationStore, () => new SuccessViewModel(navigationStore)));

            // call back function () =>

            // constructing instance of navigationService
            ParameterNavigationService<Album, SuccessViewModel> navigationService = new ParameterNavigationService<Album, SuccessViewModel>(
                navigationStore, (parameter) => new SuccessViewModel(parameter, navigationStore));

            // CreateAlbumCommand uses navigationservice, which is right above, it is going to take the parameter from factory view model and pass it on
            CreateAlbumCommand = new CreateAlbumCommand(this, navigationService);

            AddSongCommand = new AddSongCommand(this);

            AddImageCommand = new AddImageCommand(this);

            RemoveSongCommand = new RemoveSongCommand(this);


        }
        
        private void OnImagePropertyChanged() // This may not be the problemm
        {
            OnPropertyChanged(nameof(AlbumCover)); // tells display to refresh
        }
        private void OnSongArrayPropertyChanged()
        {
            OnPropertyChanged(nameof(SongArray));
        }


    }
}
