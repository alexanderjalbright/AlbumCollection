using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public abstract class IAlbumRepository
    {
        Album album;       

        public abstract Album GetById();
    }
}
