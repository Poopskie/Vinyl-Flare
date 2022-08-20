using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;

namespace Vinyl_Flare.MVVM.ViewModel
{
    public class PlaySongViewModel : ViewModelBase
    {
        private MediaPlayer mediaPlayer = new(); // initializing mp3 player

        private string _lblStatus; // property for the label to be binded
        public string lblStatus 
        {
            get => _lblStatus;
            set 
            { 
                _lblStatus = value; 
                OnlblStatusPropertyChanged();
            } 
        }

        private readonly Album _album = new();

        public string AlbumName => _album.AlbumName;
        public string AlbumImage => _album.AlbumCoverURL;


        public PlaySongViewModel(Album album) // default parameter for start
        {
            _album = album; // SHIT WORKS NOW!!!!!! - AUGUST 19TH 2022

            mediaPlayer.Open(new Uri(_album.Songs[4].URL)); // taking url from first song
            mediaPlayer.Play();

            DispatcherTimer timer = new(); // initializing timer for song
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        

        void timer_Tick(object sender, EventArgs e) // function for changing timer display
        {
            if (mediaPlayer.Source != null)
                lblStatus = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            else
                lblStatus = "No file selected...";
        }

        private void OnlblStatusPropertyChanged()
        {
            OnPropertyChanged(nameof(lblStatus));
        }


    }
}
