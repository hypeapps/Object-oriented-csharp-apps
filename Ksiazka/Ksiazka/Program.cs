using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksiazka
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaKontaktow = 0;
            int wybor;
            String[] dane = new string[9];
            Console.WriteLine("Ile kontaktów wprowadzisz?");
            liczbaKontaktow = int.Parse(Console.ReadLine());
            Console.Clear();
            Osoba[] osoba = new Osoba[liczbaKontaktow + 1];

            for (int i = 1; i <= liczbaKontaktow; i++)
            {
                Console.WriteLine("Podaj dane kontaktu nr: " + i);
                for (int j = 1; j < 8; j++)
                {
                    switch (j)
                    {
                        case 1:
                            Console.WriteLine("Podaj imie: ");
                            break;
                        case 2:
                            Console.WriteLine("Podaj nazwisko: ");
                            break;
                        case 3:
                            Console.WriteLine("Podaj ulice: ");
                            break;
                        case 4:
                            Console.WriteLine("Podaj numer domu: ");
                            break;
                        case 5:
                            Console.WriteLine("Podaj numer mieszkania: ");
                            break;
                        case 6:
                            Console.WriteLine("Podaj kod pocztowy: ");
                            break;
                        case 7:
                            Console.WriteLine("Podaj państwo: ");
                            break;
                    }
                    dane[j] = Console.ReadLine();
                    Console.Clear();
                }
                osoba[i] = new Osoba(dane[1], dane[2], dane[3], dane[4], dane[5], dane[6], dane[7], dane[8]);

            }


            do
            {
                Console.WriteLine(" \n (1)Wyświetl wszystkie konktakty \n (2)Wyświetl konkretny konktakt \n (3)Exit");
                wybor = int.Parse(Console.ReadLine());
                Console.Clear();
                if (wybor == 1)
                {
                    wyswietlWszystko(liczbaKontaktow, osoba);
                }
                else if (wybor == 2)
                {
                    wyswietlWszystko(liczbaKontaktow, osoba);
                    wyswietlPodaneKontakty(osoba);
                }
            }
            while (wybor < 3);

            
        }

        private static void wyswietlWszystko(int liczbaKontaktow, Osoba[] osoba)
        {
            Console.WriteLine("Wszystkie kontakty:");
            for (int i = 1; i <= liczbaKontaktow; i++)
            {
                Console.WriteLine(" "+ i + "." + osoba[i].PrzedstawSieIN());
            }
            Console.WriteLine(" ");
        }

        private static void wyswietlPodaneKontakty(Osoba[] osoba)
        {
            Console.WriteLine("Podaj numer kontaktu do wyswietlenia");
            int wybranyKontakt = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(osoba[wybranyKontakt].PrzedstawSie());
            Console.WriteLine(" ");
        }

       
        
    }
}
