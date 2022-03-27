using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;



namespace Vinyl_Flare
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public string DbPath { get; set; }

        public AlbumContext() // Constructor
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "test.db");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }

        public List<Song> Songs { get; set; } = new();
        // making sure to declare Songs list

        public string Image { get; set; }

    }

    public class Song
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string URL { get; set; } // Path to song

        public int? AlbumId { get; set; }
        public Album? Album { get; set; } // making an album variable in this class

    }
    
}
