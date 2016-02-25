using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer 
{
    class Metal : Song
    {
        private String sound { get; set; }
        
        public Metal(String title, String artist, String sound = "METAL SOUND")
            : base(title, artist)
        {
            this.sound = sound;
        }

        public override String Play()
        {
            return base.Play() + " " + this.sound;
        }
    }
}
