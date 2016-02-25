using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksiazka
{
    class Osoba
    {
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public Adres Adres { get; set; }

        public Osoba() { }


        public Osoba(String imie, String nazwisko, String ulica, String numerDomu, String numerMieszkania, String kodPocztowy, String miasto, String panstwo)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;

            this.Adres = new Adres();
            this.Adres.Ulica = ulica;
            this.Adres.NumerDomu = numerDomu;
            this.Adres.NumerMieszkania = numerMieszkania;
            this.Adres.KodPocztowy = kodPocztowy;
            this.Adres.Miasto = miasto;
            this.Adres.Panstwo = panstwo;
        }

        public String PrzedstawSie()
        {
            String przedstawSie = this.Imie + " " + this.Nazwisko + "\n" + this.Adres.MojAdres();
            return przedstawSie;
        }

        public String PrzedstawSieIN()
        {
            String przedstawSieIN = this.Imie + " " + this.Nazwisko;
            return przedstawSieIN;
        }
    }
}
