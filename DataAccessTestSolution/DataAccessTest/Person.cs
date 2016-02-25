using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTest
{
    class Person 
    {
        public int Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }


        public Person(int pesel, string imie, string nazwisko)
        {
            this.Pesel = pesel;
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }

        public override String ToString(){
            return Imie + " " + Nazwisko + " " + Pesel;
        }


    }


    
}
