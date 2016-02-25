using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class NewschoolRap : Rap
    {
        private String sound{get; set;}

        public NewschoolRap(String title, String artist, String sound = "NEWSCHOOL RAP SOUND")
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
