using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class OldschoolRap : Rap
    {
        private String sound{get; set;}

        public OldschoolRap(String title, String artist, String sound = "OLDSCHOOL RAP SOUND")
            : base(title, artist)
        {
            this.sound = sound;
        }

        public override String Play()
        {
            return base.Play() + "/" + this.sound;
        }
    }
}
