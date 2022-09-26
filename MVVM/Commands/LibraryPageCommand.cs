using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    public class LibraryPageCommand : CommandBase
    {
        private int PageValue;
        private LibraryViewModel LibraryViewModel;
        private string Command;
        public LibraryPageCommand(LibraryViewModel libraryViewModel, int pageValue, string command)
        {
            PageValue = pageValue;
            LibraryViewModel = libraryViewModel;
            Command = command;
        }
        public override void Execute(object parameter)
        {
            if (Command == "next"){
                LibraryViewModel.NextPageCommand();
            } else if(Command == "last")
            {
                LibraryViewModel.LastPageCommand();
            }
        }
    }
}
