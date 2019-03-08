using AlbumCollection.Controllers;
using AlbumCollection.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace AlbumCollection.Tests
{
    public class AlbumControllerTests
    {
        AlbumController underTest;

        public AlbumControllerTests()
        {
            underTest = new AlbumController();
        }

        [Fact]
        public void Album_Controller_Returns_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Album_Controller_View_Has_Model()
        {
            var expected = 1;

            var model = (Album)underTest.Index().Model;

            var result = model.AlbumId;

            Assert.Equal(expected, result);
        }
    }
}
