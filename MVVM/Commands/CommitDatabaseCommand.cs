﻿using Microsoft.Data.Sqlite;
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
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateLibraryCommand { get; }
        public Album _album { get; set; }

        public CommitDatabaseCommand(SuccessViewModel viewModel)
        {
            _viewModel = viewModel; // getting data from viewModel

            NavigateLibraryCommand = _viewModel.NavigateLibraryCommand;
            NavigateHomeCommand = _viewModel.NavigateHomeCommand;
        }


        public override void Execute(object parameter)
        { // adding data to DB
            // Referes to: AlbumContext which is my model
            _album = _viewModel._album;
            using (var db = new AlbumContext()) // using EF core to simplify syntax
            {
                //int size = _album.Songs.Count(); // size of the list of songs
                
                //for (int i = 0; i < size; i++) // add each song in the list to the db
                //{
                //    db.Songs.Add(_album.Songs[i]);
                //}
                
                db.Albums.Add(_album); // Adding the Album using EFcore instead of SQlite
                db.SaveChanges();
  //              var foundalbum = db.Albums.OrderBy(a => a.AlbumId).Last(); // newest addition to db



            }

            NavigateHomeCommand.Execute(parameter);

        }


    }
}
