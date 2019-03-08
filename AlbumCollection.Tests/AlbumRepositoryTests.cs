using AlbumCollection.Models;
using AlbumCollection.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlbumCollection.Tests
{
    public class AlbumRepositoryTests
    {
        AlbumRepository underTest;
        public AlbumRepositoryTests()
        {
            var db = new CollectionContext();
            underTest = new AlbumRepository(db);
        }

        [Fact]
        public void GetById_Returns_One_Album()
        {
            var expected = 1;

            var result = underTest.GetById(expected);

            Assert.IsType<Album>(result);
        }

        [Fact]
        public void GetAll_Returns_All_Albums()
        {
            var result = underTest.GetAll();

            Assert.IsType<List<Album>>(result);
        }
    }
}
