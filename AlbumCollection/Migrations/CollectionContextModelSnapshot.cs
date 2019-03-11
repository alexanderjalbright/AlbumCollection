﻿// <auto-generated />
using AlbumCollection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollection.Migrations
{
    [DbContext(typeof(CollectionContext))]
    partial class CollectionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumCollection.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Name");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { AlbumId = 1, Artist = "Modest Mouse", ImageURL = "/images/LongDrive.jpg", Name = "This Is a Long Drive for Someone with Nothing to Think About" },
                        new { AlbumId = 2, Artist = "Modest Mouse", ImageURL = "/images/CrowdedWest.jpg", Name = "The Lonesome Crowded West" },
                        new { AlbumId = 3, Artist = "Modest Mouse", ImageURL = "/images/Moon.jpg", Name = "The Moon & Antarctica" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("Name");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Song");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, Name = "Dramamine" },
                        new { SongId = 2, AlbumId = 1, Name = "Breakthrough" },
                        new { SongId = 3, AlbumId = 2, Name = "Teeth Like God's Shoeshine" },
                        new { SongId = 4, AlbumId = 2, Name = "Heart Cooks Brain" },
                        new { SongId = 5, AlbumId = 3, Name = "3rd Planet" },
                        new { SongId = 6, AlbumId = 3, Name = "Gravity Rides Everything" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.HasOne("AlbumCollection.Models.Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
