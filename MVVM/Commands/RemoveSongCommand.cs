using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    public class RemoveSongCommand : CommandBase
    {
        // This Command needs all songs in the current album
        private FactoryViewModel _viewModel { get; set; }

        public readonly List<Song> _songList = new();

        public RemoveSongCommand(FactoryViewModel viewModel)
        {
            _viewModel = viewModel;
            _songList = viewModel.SongArray; // setting _songList
        }

        public override void Execute(object parameter)
        {
            // display component on viewmodel
            // (make isvisible = true)

            
        }
    }
}
