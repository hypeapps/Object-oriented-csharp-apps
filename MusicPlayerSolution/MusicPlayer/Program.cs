using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            String result;
            Player player = new Player();
            Song song;
            
            do
            {
                Console.WriteLine("Podaj gatunek utworu [ Metal . Alternative Metal . Rap . Newschool Rap . Oldschool Rap ] ");
                String genre = Console.ReadLine();
                Console.WriteLine("Podaj tytuł utworu");
                String title = Console.ReadLine();
                Console.WriteLine("Podaj nazwę wykonawcy");
                String artist = Console.ReadLine();

                if (genre.Equals("Metal"))
                {
                    Metal metal = new Metal(title, artist);
                    player.Add(metal);
                }
                else if (genre.Equals("Alternative Metal"))
                {
                    AlternativeMetal alternativeMetal = new AlternativeMetal(title, artist);
                    player.Add(alternativeMetal);
                }
                else if (genre.Equals("Rap"))
                {
                    song = new Rap(title, artist);
                    player.Add(song);
                }
                else if (genre.Equals("Oldschool Rap"))
                {
                    song = new OldschoolRap(title, artist);
                    player.Add(song);
                }
                else if (genre.Equals("Newschool Rap"))
                {
                    song = new NewschoolRap(title, artist);
                    player.Add(song);
                }

                Console.WriteLine("Chcesz wprowadzić kolejny utwór? (t/n)");
                result = Console.ReadLine();
                Console.Clear();

            } while (result == "t");
            
            for (int i = 0; i < player.songList.Count ; i++)
            {
                Console.WriteLine(player.Play(i));
            }


            //Song metal = new Metal("Anakin", "SOAD");
            //Song alternativeMetal = new AlternativeMetal("Przemek", "wybitny");
            //Song rap = new Rap("ELDO", "USZY");
            //Song newschoolRap = new NewschoolRap("QUEB", "NAFIDE");
            //Console.WriteLine(metal.Play());
            //Console.WriteLine(alternativeMetal.Play());
            //Console.WriteLine(rap.Play());
            //Console.WriteLine(newschoolRap.Play());
            //Player player = new Player();
            //player.Add(rap);
            //Console.WriteLine(player.Play(0));
            Console.ReadKey();
        }
    }
}
