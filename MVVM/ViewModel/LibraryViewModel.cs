using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinyl_Flare.MVVM.Store;

namespace Vinyl_Flare.MVVM.ViewModel
{
    public class LibraryViewModel : ViewModelBase
    {

        //Used to be: public LibararyViewModel(Album album, NavigationStore navigationStore)
        // don't need to recieve album here, cuz we will simply add to database in the command.

        public LibraryViewModel(NavigationStore navigationStore)
        {

        }



    }
}
