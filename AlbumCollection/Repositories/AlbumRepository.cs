using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        CollectionContext db;

        public AlbumRepository(CollectionContext db)
        {
            this.db = db;
        }

        public Album GetById(int id)
        {
            return db.Albums.Single(album => album.AlbumId == id);
        }

        public IEnumerable<Album> GetAll()
        {
            return db.Albums.ToList();
        }
    }
}
