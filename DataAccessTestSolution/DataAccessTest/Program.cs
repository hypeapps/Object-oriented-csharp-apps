using System;
using DataAccessTest;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database("Moja baza");
            List<Person> persons = new List<Person>();
            List<Dictionary<string, object>> personsData;
            
            //EXCEPTIONS

            //IConnection con = new Connection("123", "asdf", database);
            //con.Close();
            //database.GetData(con);

            //try
            //{
            //    database.GetNewConnection("asdf", "122223");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            
            //string x2;
            //object x4;
            //personsDatas = personsData.ToDictionary(x1 => x2,  x3 => x4);

            personsData = database.GetData(database.GetNewConnection("asdf", "123"));

            for (int i = 0; i < 10; i++)
            {
                string pesel = personsData[i]["pesel"].ToString();
                string imie = personsData[i]["imie"].ToString();
                string nazwisko = personsData[i]["nazwisko"].ToString();
                int peselBuf;
                Int32.TryParse(pesel, out peselBuf);
                Person person = new Person(peselBuf, imie, nazwisko);
                persons.Add(person);
            }

            for (int i = persons.Count - 1; i >= 0; i--)
            {
                if (persons[i].Pesel % 2 == 0)
                {
                    persons.RemoveAt(i);
                }
            }

            persons.Sort(delegate(Person x, Person y)
            {
                return x.Pesel.CompareTo(y.Pesel);
            });

            for (int i = 0; i <= persons.Count - 1; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
               
                Console.ReadKey();
        }
    }
}
