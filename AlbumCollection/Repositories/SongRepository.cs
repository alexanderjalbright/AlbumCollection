using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public class SongRepository : ISongRepository
    {
        DbContext db;
        public SongRepository(CollectionContext db)
        {
            this.db = db;
        }

        public void Create(Song song)
        {
            db.Add(song);
            db.SaveChanges();
        }
    }
}
