using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    public class AddSongCommand : CommandBase
    {
        private FactoryViewModel _viewModel { get; set; } // need to edit values in here
        private Song newSong; // make sure to initialize Song
        private List<Song> newSongList = new();

        public AddSongCommand(FactoryViewModel viewModel)
        {
            _viewModel = viewModel;
            // refers directly and edits the Factory Viewmodel
        }

        public override void Execute(object parameter)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Title = "Select Song";


            //settings for the box
            dialog.DefaultExt = ".mp3";
            dialog.Filter = "Audio Files|*.mp3;*.wav;*.ra;*.ram;*.au;*.aiff";
            dialog.CheckPathExists = true;
            dialog.CheckFileExists = true;

            // This would be the next step, multiple songs
            //      dialog.Multiselect = true;

            // This supposidly creates the dialog
            Nullable<bool> result = dialog.ShowDialog(); // show dialog after settings applied

            if (result == true)
            { // here is the logic for the information transfer
              // uised to be: _viewModel.SongArray.Count()
              //      newSong.Id =  1;
              //    newSong.SongName = dialog.SafeFileName; // name of file without paht
              //  newSong.URL = dialog.FileName; // path of file

                // using constructor instead
                newSong = new Song();
           //     newSong.SongId = _viewModel.SongArray.Count() + 1;
                newSong.SongName = dialog.SafeFileName;
                newSong.URL = dialog.FileName;

                newSongList = _viewModel.SongArray; // getting copy
                newSongList.Add(newSong); // adding the new song
                _viewModel.SongArray = newSongList; // setting old value

            }

            
        }
    }
}
