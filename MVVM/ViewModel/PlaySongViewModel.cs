﻿using NavigationMVVM.ViewModels;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Vinyl_Flare.MVVM.Commands;

namespace Vinyl_Flare.MVVM.ViewModel
{
    public class PlaySongViewModel : ViewModelBase
    {
        public MediaPlayer mediaPlayer = new(); // initializing mp3 player

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

        public ICommand Pause { get; }
        public ICommand Play { get; }
        public ICommand Skip { get; }
        // double for slider
        private double _volumeBinder = 0.5;
        public double volumeBinder
        {
            get => _volumeBinder;
            set
            {
                _volumeBinder = value;
                volumeChanged();
            }
        }
        // using double to bind to slider
        private string _songNow;
        public string SongNow 
        { 
            get => _songNow; 
            set 
            { 
                _songNow = value; 
                OnSongNowPropertyChanged(); 
            } 
        } // prop for song name

        private int _songPlaying;
        public int SongPlaying
        {
            get => _songPlaying;
            set
            {
                _songPlaying = value;
            }
        }

        private DispatcherTimer timer = new(); // initializing timer for song

        public PlaySongViewModel(Album album) // default parameter for start
        {
            _album = album; // SHIT WORKS NOW!!!!!! - AUGUST 19TH 2022

            SongPlaying = 0;
            mediaPlayer.Open(new Uri(_album.Songs[SongPlaying].URL)); // taking url from first song
            mediaPlayer.Play();

            Pause = new MediaControl(mediaPlayer, "pause"); // Initializing media control commands
            Play = new MediaControl(mediaPlayer, "play");
            Skip = new MediaControl(mediaPlayer, "skip");
            SongNow = _album.Songs[SongPlaying].SongName; // initializing songname

            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void volumeChanged()
        {
            mediaPlayer.Volume = volumeBinder;
        }
        

        private void timer_Tick(object sender, EventArgs e) // function for changing timer display
        {
            if (mediaPlayer.Source != null)
                lblStatus = String.Format("{0} / {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            else
                lblStatus = "No file selected...";

            if (mediaPlayer.Position.TotalMilliseconds == mediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds)
            {
                mediaPlayer.Stop(); // switching to next song after one finishes
                if (SongPlaying <= _album.Songs.Count)
                { // checking to make sure there are more songs
                    SongPlaying += 1;
                    mediaPlayer.Open(new Uri(_album.Songs[SongPlaying].URL));
                    mediaPlayer.Play();
                    SongNow = _album.Songs[SongPlaying].SongName; // updating prop with song name
                }
            }

        }

        ~PlaySongViewModel() // DESTRUCTOR
        {

        }


        private void OnlblStatusPropertyChanged()
        {
            OnPropertyChanged(nameof(lblStatus));
        }

        private void OnSongNowPropertyChanged()
        {
            OnPropertyChanged(nameof(SongNow));
        }

        public override void Dispose()
        {
            mediaPlayer.Close();
            timer.Stop();
            timer.Tick -= timer_Tick;

            base.Dispose();
        }


    }
}
