using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTest
{
    public class Database : IDatabase
    {
        private string databaseName;


        public Database(string databaseName)
        {
            this.databaseName = databaseName;
        }

        public IConnection GetNewConnection(string userName, string password)
        {
            var iConnection = new Connection(userName, password, this);
            iConnection.Open();
            return iConnection;
        }

        public List<Dictionary<string, object>> GetData(IConnection connection)
        {
            if ((!connection.IsOpen()))
            {
                ConnectionClosedException connectionClosedException =
                    new ConnectionClosedException("Próba pobrania danych z bazy przy zamkniętym połączeniu");
                throw connectionClosedException;
            }
            else
            {

                //List<Dictionary<string, object>> dictList = new List<Dictionary<string, object>>();
                //dictList.Add()
                
                //Dictionary<string, object> dict = new Dictionary<string, object>()
                //{
                //    {"key_1", new{pesel=1, name="name_1", lastName="nazwisko_1"}},
                //    {"key_2", new{pesel=2, name="name_2", lastName="nazwisko_2"}},
                //    {"key_3", new{pesel=3, name="name_3", lastName="nazwisko_3"}},
                //    {"key_4", new{pesel=4, name="name_4", lastName="nazwisko_4"}},
                //    {"key_5", new{pesel=5, name="name_5", lastName="nazwisko_5"}}

                //};


                //List<Dictionary<string, object>> dictlist = new List<Dictionary<string, object>>();
                //dictlist[0].Add("key_1",dictlist[0]);

                List<Dictionary<string, object>> dictList = new List<Dictionary<string, object>>();

                for (int i = 0; i < 10; i++)
                {
                    Dictionary<string, object> dict = new Dictionary<string, object>();
                    dict.Add("pesel", i);
                    dict.Add("imie", "Imie_" + i);
                    dict.Add("nazwisko", "Nazwisko_" + i);
                    dictList.Add(dict);
                }
                return dictList;
            }
        }

        public string GetDatabaseName()
        {
            return databaseName;
        }


    }
}
