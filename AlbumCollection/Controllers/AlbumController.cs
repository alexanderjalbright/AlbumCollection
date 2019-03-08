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

        public ViewResult Index()
        {
            var model = repo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = repo.GetById(id);
            return View(model);
        }
    }
}