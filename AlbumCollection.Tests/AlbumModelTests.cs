using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlbumCollection.Tests
{
    public class AlbumModelTests
    {
        [Fact]
        public void Album_Contains_Id()
        {
            int expected = 1;
            var underTest = new Album() { AlbumId = expected };

            var result = underTest.AlbumId;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Album_Contains_Name()
        {
            string expected = "Ocean Breathes Salty";
            var underTest = new Album() { Name = expected };

            var result = underTest.Name;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Album_Contains_Artist()
        {
            string expected = "Modest Mouse";
            var underTest = new Album() { Artist = expected };

            var result = underTest.Artist;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Album_Contains_List_Of_Songs()
        {
            var underTest = new Album() { Songs = new List<Song>() };

            var result = underTest.Songs;

            Assert.IsType<List<Song>>(result);
        }
    }
}
