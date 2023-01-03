using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    public class LeavePlaySongCommand : CommandBase
    {
        MainViewModel mainViewModel;
        public LeavePlaySongCommand (MainViewModel mainviewmodel)
        {
            mainViewModel = mainviewmodel;

        }

        public override void Execute(object parameter)
        {
            mainViewModel.LeavePlaySongFunction();

        }
    }
}
