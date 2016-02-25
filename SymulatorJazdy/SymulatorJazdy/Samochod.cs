using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SymulatorJazdy
{
    class Samochod
    {
        public String Marka;
        public String Model { get; set; }
        public Silnik Silnik { get; set; }

        public Samochod() { }

        public Samochod(String marka, String model, double pojemnosc, double iloscPaliwa, double pojemnoscZbiornika)
            : this(marka, model, pojemnosc, iloscPaliwa)
        {
            this.Silnik.PojemnoscZbiornika = pojemnoscZbiornika;
        }

        public Samochod(String marka, String model, double pojemnosc, double iloscPaliwa)
        {
            this.Marka = marka;
            this.Model = model;
            this.Silnik = new Silnik();
            this.Silnik.Pojemnosc = pojemnosc;
            this.Silnik.IloscPaliwa = iloscPaliwa;
        }

        public Samochod(String marka, String model, Silnik silnik)
        {
            this.Marka = marka;
            this.Model = model;
            this.Silnik = silnik;
        }

        public void Jedz(double dystans)
        {
            double spalanieNa100 = this.Silnik.Pojemnosc * 4;
            double spalonePaliwo = spalanieNa100 * (dystans / 100);
            if (this.Silnik.IloscPaliwa < spalonePaliwo)
            {
                Console.WriteLine("Nie przejedziesz takiego dystansu!");
                return;
            }
            Console.WriteLine("Jadę!   Masz: " + this.Silnik.IloscPaliwa + " paliwa");
            this.Silnik.Dzialaj(dystans);
            Console.WriteLine("Jestem!   Masz: " + this.Silnik.IloscPaliwa + " paliwa");
            Tankuj();
        }

        private void Tankuj()
        {
            Console.WriteLine("Chcesz zatankować? Y/N");
            String choice = Console.ReadLine();
            if (choice.Equals("Y"))
            {
                Console.WriteLine("Podaj ilosc paliwa (POJEMNOSC ZBIORNIKA " +this.Silnik.IloscPaliwa + "/" + this.Silnik.PojemnoscZbiornika + "L)");
                double plusPaliwo = double.Parse(Console.ReadLine());
                Console.Clear();
                while (plusPaliwo + this.Silnik.IloscPaliwa > this.Silnik.PojemnoscZbiornika)
                {
                    Console.Clear();
                    Console.WriteLine("Chcesz zatankować za dużo paliwa (Mozesz zatankowac jeszcze " + (this.Silnik.PojemnoscZbiornika - this.Silnik.IloscPaliwa) + " paliwa maksymalnie)");
                    Console.WriteLine("Podaj ilosc paliwa (POJEMNOSC ZBIORNIKA " + this.Silnik.IloscPaliwa + "/" + this.Silnik.PojemnoscZbiornika + "L)");
                    plusPaliwo = double.Parse(Console.ReadLine());
                }
                double plusPaliwo2 = plusPaliwo;
                this.Silnik.IloscPaliwa += plusPaliwo;
                Console.WriteLine("Zatankowałeś " + plusPaliwo + " Masz: " + this.Silnik.IloscPaliwa + " paliwa.");
            }
        }

        public void AnimCar(int frame)
        {
            if (frame == 0)
            {
                frame1();
            }
            else if (frame == 1)
            {
                frame2();
            }
            else if (frame == 2)
            {
                frame3();
            }
            else if (frame == 3)
            {
                frame4();
            }


            Thread.Sleep(100);

        }

        public void frame1()
        {
            Console.WriteLine("");
            Console.WriteLine("            _________________________ ");
            Console.WriteLine("   _      __ /  ,------++---. .-------.`.");
            Console.WriteLine("      _     /  /      //    | ||       |.`.");
            Console.WriteLine("        __ /  /      //     | ||       | `.`.");
            Console.WriteLine("  __   __ |  '------++------' |`-------+--[)| `---..___ ");
            Console.WriteLine("       __ !]            _     |             |    ______'''-.");
            Console.WriteLine("   _     _!]__________ |_|    |             |   ,,----.\\___|_");
            Console.WriteLine("    _    |___ /',--. \\       |_____________|  // ,--.\\____|");
            Console.WriteLine(" _       \\_- /' |   | !\\----------------------'| |    |!|_/");
            Console.WriteLine("             \\  '--' /!'----------------------'\\ '---' /");
            Console.WriteLine("               ''---'                            ''---'");
            Console.WriteLine("-------- ---- -- - -- - - -- - -- -  - - -- ------- - - - - -- -- ");

        }

        public void frame2()
        {
            Console.WriteLine("            _________________________ ");
            Console.WriteLine("    __    __ /  ,------++---. .-------.`.");
            Console.WriteLine("  _         /  /      //    | ||       |.`.");
            Console.WriteLine("    _   __ /  /      //     | ||       | `.`.");
            Console.WriteLine("       __ |  '------++------' |`-------+--[)| `---..___ ");
            Console.WriteLine("  _    __ !]            _     |             |          '''-.");
            Console.WriteLine("         _!]_____      |_|    |             |    ______    |_");
            Console.WriteLine("         _!]__________        |             |   ,,----.\\___|_");
            Console.WriteLine("  __     |___ /',--. \\       |_____________|  // ,--.\\____|");
            Console.WriteLine("         \\_- /' |   | !\\----------------------'| |    |!|_/");
            Console.WriteLine("             \\  '--' /!'----------------------'\\ '---' /");
            Console.WriteLine("               ''---'                            ''---'");
            Console.WriteLine("-- -  - --- -- - -- - - -- - -- -  - - -- ------- - - - - -- -- ");

        }
        public void frame3()
        {
            Console.WriteLine("");
            Console.WriteLine("    _       _________________________ ");
            Console.WriteLine("          __ /  ,------++---. .-------.`.");
            Console.WriteLine("    ___     /  /      //    | ||       |.`.");
            Console.WriteLine("        __ /  /      //     | ||       | `.`.");
            Console.WriteLine(" _     __ |  '------++------' |`-------+--[)| `---..___ ");
            Console.WriteLine("       __ !]            _     |             |    ______'''-.");
            Console.WriteLine("   __    _!]__________ |_|    |             |   ,,----.\\___|_");
            Console.WriteLine("         |___ /',--. \\       |_____________|  // ,--.\\____|");
            Console.WriteLine("     _   \\_- /' |   | !\\----------------------'| |    |!|_/");
            Console.WriteLine("             \\  '--' /!'----------------------'\\ '---' /");
            Console.WriteLine("               ''---'                            ''---'");
            Console.WriteLine("---   ---- -- - - --  - -- - -- -  - - -- -- --- - - - - -- -- ");

        }

        public void frame4()
        {
            Console.WriteLine("            _________________________ ");
            Console.WriteLine("__        __ /  ,------++---. .-------.`.");
            Console.WriteLine("     __     /  /      //    | ||       |.`.");
            Console.WriteLine("        __ /  /      //     | ||       | `.`.");
            Console.WriteLine("  __   __ |  '------++------' |`-------+--[)| `---..___ ");
            Console.WriteLine("       __ !]            _     |             |          '''-.");
            Console.WriteLine("         _!]_____      |_|    |             |    ______    |_");
            Console.WriteLine("    _    _!]__________        |             |   ,,----.\\___|_");
            Console.WriteLine("__       |___ /',--. \\       |_____________|  // ,--.\\____|");
            Console.WriteLine("      _  \\_- /' |   | !\\----------------------'| |    |!|_/");
            Console.WriteLine("             \\  '--' /!'----------------------'\\ '---' /");
            Console.WriteLine("               ''---'                            ''---'");
            Console.WriteLine(" --- ---- ---- - - --- -- - - -- - -- -  - - -- ---- - - - -- -- ");
        }




    }
}
