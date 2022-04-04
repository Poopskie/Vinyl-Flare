using Microsoft.Data.Sqlite;
using NavigationMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinyl_Flare.MVVM.ViewModel;

namespace Vinyl_Flare.MVVM.Commands
{
    public class CommitDatabaseCommand : CommandBase
    {
        private readonly ViewModelBase _viewModel;
        private readonly Album _album;

        public CommitDatabaseCommand(SuccessViewModel viewModel)
        {
            _viewModel = viewModel; // getting data from viewModel
            _album = viewModel._album;
        }


        public override void Execute(object parameter)
        { // adding data to DB
            using (var connection = new SqliteConnection("Data Source=test.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                    @"


                    ";
            }



        }


    }
}
