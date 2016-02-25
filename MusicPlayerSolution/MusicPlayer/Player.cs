using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusicPlayer
{
    class Player
    {
        public List<Song> songList = new List<Song>();
        
        public void Add(Song song)
        {
            songList.Add(song);
        }

        public void Remove(int songNumber)
        {
            songList.RemoveAt(songNumber - 1);
        }

        public String Play(int songNumber)
        {
            return songList[songNumber].Play();
        }
    }
}
