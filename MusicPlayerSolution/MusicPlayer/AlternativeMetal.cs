using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer 
{
    class AlternativeMetal : Metal
    {
        private String sound{get; set;}

        public AlternativeMetal(String title, String artist, String sound = "ALTERNATIVE METAL SOUND")
            :base(title, artist, sound)
        {}

        public override String Play()
        {
            return base.Play() + "/" + this.sound;
        }
    }
}
