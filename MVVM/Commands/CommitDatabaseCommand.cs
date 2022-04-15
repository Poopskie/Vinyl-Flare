using Microsoft.Data.Sqlite;
using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    public class CommitDatabaseCommand : CommandBase
    {
        private readonly SuccessViewModel _viewModel;
        public ICommand NavigateLibraryCommand { get; }
        public Album _album { get; set; }

        public CommitDatabaseCommand(SuccessViewModel viewModel)
        {
            _viewModel = viewModel; // getting data from viewModel

            NavigateLibraryCommand = _viewModel.NavigateLibraryCommand;
        }


        public override void Execute(object parameter)
        { // adding data to DB
            // Referes to: AlbumContext which is my model
            _album = _viewModel._album;
            using (var db = new AlbumContext()) // using EF core to simplify syntax
            {
                db.Add(_album); // Adding the Album using EFcore instead of SQlite
                db.SaveChanges();


            }

            NavigateLibraryCommand.Execute(parameter);

        }


    }
}
