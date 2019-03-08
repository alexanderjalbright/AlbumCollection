using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    public class SongController : Controller
    {
        ISongRepository repo;
        public SongController(ISongRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ViewResult Create(int id)
        {
            var model = new Song() { AlbumId = id };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            repo.Create(song);
            return RedirectToAction("Details/"+ song.AlbumId, "Album");
        }
    }
}