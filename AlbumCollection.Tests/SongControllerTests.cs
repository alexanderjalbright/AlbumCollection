using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlbumCollection.Tests
{
    public class SongControllerTests
    {
        SongController underTest;
        ISongRepository repo;

        public SongControllerTests()
        {
            this.repo = Substitute.For<ISongRepository>(); ;
            underTest = new SongController(repo);
        }        

        [Fact]
        public void Album_Details_Has_View()
        {
            var id = 1;
            var result = underTest.Create();

            Assert.IsType<ViewResult>(result);
        }
    }
}
