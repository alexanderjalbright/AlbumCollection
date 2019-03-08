using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection
{
    public class CollectionContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=AlbumCollectionAJA;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData
                (
                    new Album()
                    {
                        AlbumId = 1,
                        Name = "This Is a Long Drive for Someone with Nothing to Think About",
                        Artist = "Modest Mouse"
                    },
                    new Album()
                    {
                        AlbumId = 2,
                        Name = "The Lonesome Crowded West",
                        Artist = "Modest Mouse"
                    },
                    new Album()
                    {
                        AlbumId = 3,
                        Name = "The Moon & Antarctica",
                        Artist = "Modest Mouse"
                    }
                );

            modelBuilder.Entity<Song>().HasData
                (
                    new Song()
                    {
                        AlbumId = 1,
                        Name = "Dramamine",
                        SongId = 1
                    },
                    new Song()
                    {
                        AlbumId = 1,
                        Name = "Breakthrough",
                        SongId = 2
        },
                    new Song()
                    {
                        AlbumId = 2,
                        Name = "Teeth Like God's Shoeshine",
                        SongId = 3
        },
                    new Song()
                    {
                        AlbumId = 2,
                        Name = "Heart Cooks Brain",
                        SongId = 4
        },
                    new Song()
                    {
                        AlbumId = 3,
                        Name = "3rd Planet",
                        SongId = 5
        },
                    new Song()
                    {
                        AlbumId = 3,
                        Name = "Gravity Rides Everything",
                        SongId = 6
        }
                );

            base.OnModelCreating(modelBuilder);


        }

    }
}
