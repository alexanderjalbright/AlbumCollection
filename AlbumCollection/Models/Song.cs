using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Song
    {
        public int SongId { get; set; }
        
        public string Name { get; set; }

        public virtual int AlbumId { get; set; }
    }
}
