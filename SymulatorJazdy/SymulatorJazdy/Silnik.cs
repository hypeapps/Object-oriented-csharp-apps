using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymulatorJazdy
{
    class Silnik
    {
        public double Pojemnosc { get; set; }
        public double IloscPaliwa { get; set; }
        public double PojemnoscZbiornika { get; set; }
        public Samochod Samochod { get; set; }
        
        public Silnik() { }
        public Silnik(int pojemnosc, double iloscPaliwa)
        {
            this.Pojemnosc = pojemnosc;
            this.IloscPaliwa = iloscPaliwa;
            this.PojemnoscZbiornika = 50;
        }

        public Silnik(int pojemnosc, double iloscPaliwa, int pojemnoscZbiornika)
            : this(pojemnosc, iloscPaliwa)
        {
            this.PojemnoscZbiornika = pojemnoscZbiornika;
        }

        public static double ConvertLKmToMpg(double spalanie)
        {
            return (378.541 / spalanie) * 0.62137;
        }

        public static double ConvertMpgToLKM(double spalanie)
        {
            return 378.541 / (spalanie * 1.60934);
        }

        public void Dzialaj(double dystans)
        {
            double spalanieNa100 = this.Pojemnosc * 4;
            double copyIloscPaliwa = this.IloscPaliwa;
            int x = 0;
            
            this.Samochod = new Samochod();
            for (double i = 0; i <= dystans; i++)
            {
                copyIloscPaliwa -= spalanieNa100 * (i / 100);
                Console.WriteLine("                       Masz: " + copyIloscPaliwa.ToString("F1") + " paliwa");
                Console.WriteLine("                       Kilometrow do celu: " + (dystans - i) + "km");
                copyIloscPaliwa = this.IloscPaliwa;
                this.Samochod.AnimCar(x);
                x++;
                if (x == 4)
                {
                    x = 0;
                }
                Console.Clear();
            }
            this.IloscPaliwa -= spalanieNa100 * (dystans / 100);
        }
    }
}
