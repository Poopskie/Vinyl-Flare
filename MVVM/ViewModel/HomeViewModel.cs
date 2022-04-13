﻿using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinyl_Flare.MVVM.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly Album _album = new();

        public string AlbumName => _album.AlbumName;
        public string AlbumImage => _album.Image;


        public HomeViewModel(Album album = null) // default parameter for start
        {
            _album = album;

        }
    }
}
