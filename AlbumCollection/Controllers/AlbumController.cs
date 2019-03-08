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
        AlbumRepository repo;
        public AlbumController(AlbumRepository repo)
        {
            this.repo = repo;
        }

        public ViewResult Index()
        {
            var model = repo.GetById();
            return View(model);
        }
    }
}