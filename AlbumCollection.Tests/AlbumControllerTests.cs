using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using Xunit;

namespace AlbumCollection.Tests
{
    public class AlbumControllerTests
    {
        AlbumController underTest;
        IAlbumRepository repo;

        public AlbumControllerTests()
        {
            this.repo = Substitute.For<IAlbumRepository>(); ;
            underTest = new AlbumController(repo);
        }

        [Fact]
        public void Album_Controller_Returns_View()
        {
            var id = 1;
            var result = underTest.Index(id);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Album_Controller_View_Has_Model()
        {
            var expectedId = 1;
            var expectedModel = new Album() { AlbumId = expectedId } ;
            repo.GetById(expectedId).Returns(expectedModel);

            var model = (Album)underTest.Index(expectedId).Model;
            var result = model.AlbumId;

            Assert.Equal(expectedId, result);
        }        
    }
}
