using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
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
        public void Album_Index_Has_Model()
        {
            var expectedModel = new List<Album>();
            repo.GetAll().Returns(expectedModel);

            var result = (List<Album>)underTest.Index().Model;

            Assert.IsType<List<Album>>(result);
        }

        [Fact]
        public void Album_Details_Has_View()
        {
            var id = 1;
            var result = underTest.Details(id);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Album_Details_Has_Model()
        {
            var expectedId = 1;
            var expectedModel = new Album() { AlbumId = expectedId } ;
            repo.GetById(expectedId).Returns(expectedModel);

            var model = (Album)underTest.Details(expectedId).Model;
            var result = model.AlbumId;

            Assert.Equal(expectedId, result);
        }     
    }
}
