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
        private FactoryViewModel _viewModel;
        private Song newSong;

        public AddSongCommand(FactoryViewModel viewModel)
        {
            _viewModel = viewModel;
            // CURRENT PROBLEM: might not edit array in view model, but just the clone of it
        }

        public override void Execute(object parameter)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Title = "Select Song";

            // This supposidly creates the dialog
            Nullable<bool> result = dialog.ShowDialog();

            //settings for the box
            dialog.Filter = "Audio Files|*.mp4;*.wav;*.ra;*.ram;*.au;*.aiff";
            dialog.CheckPathExists = true;
            dialog.CheckFileExists = true;
            // This would be the next step, multiple songs
            //      dialog.Multiselect = true;

            if (result == true)
            { // here is the logic for the information transfer
                newSong.Id = _viewModel.SongArray.Count + 1;
                newSong.SongName = dialog.SafeFileName; // name of file without paht
                newSong.URL = dialog.FileName; // path of file

                _viewModel.SongArray.Add(newSong); 

            }

            
        }
    }
}
