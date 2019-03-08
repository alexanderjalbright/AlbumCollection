using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    public class AlbumController : Controller
    {
        IAlbumRepository repo;
        public AlbumController(IAlbumRepository repo)
        {
            this.repo = repo;
        }

        public ViewResult Index(int id)
        {
            var model = repo.GetById(id);
            return View(model);
        }
    }
}