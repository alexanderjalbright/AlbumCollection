using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public class AlbumRepository
    {
        Album album;

        public AlbumRepository()
        {
            this.album = new Album() { AlbumId = 1, Artist = "Modest Mouse", Name = "Ocean Breathes Salty" };
        }

        public Album GetById()
        {
            return album;
        }
    }
}
