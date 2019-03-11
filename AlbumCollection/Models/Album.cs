using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Name { get; set; }

        public string Artist { get; set; }

        public string ImageURL { get; set; }
        public virtual List<Song> Songs { get; set; }
    }
}
