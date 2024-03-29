﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Media.Imaging;
using Microsoft.EntityFrameworkCore;



namespace Vinyl_Flare
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; } // need this for songs to save
        public string DbPath { get; set; }

        public AlbumContext() // Constructor for path to db
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "test.db"); // path to db

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}"); // sqlist on db location

    }
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }

        public List<Song> Songs { get; set; } // can us = new(); to be nullable
        // making sure to declare Songs list

        public string AlbumCoverURL { get; set; }

    }


    public class Song
    {
        public int SongId { get; set; } // no need to set, will automatically be set
        public string SongName { get; set; }
        public string URL { get; set; } // Path to song

        public int? AlbumId { get; set; }
        public Album? Album { get; set; } // making an album variable in this class

    }
    
}
