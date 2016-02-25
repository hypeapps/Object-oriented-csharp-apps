using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Song
    {
        public String Title { get; set; }
        public String Artist { get; set; }

        public Song(String title, String artist)
        {
            this.Title = title;
            this.Artist = artist;
        }

        public virtual String Play()
        {
            return this.Title + " " + this.Artist;
        }
    }
}
