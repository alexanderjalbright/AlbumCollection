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
        [Fact]
        public void Repo_Returns_Album()
        {
            var underTest = new AlbumRepository();

            var result = underTest.GetById();

            Assert.IsType<Album>(result);
        }
    }
}
