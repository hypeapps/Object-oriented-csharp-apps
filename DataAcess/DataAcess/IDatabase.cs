using System.Collections.Generic;

namespace DataAccessTest
{
    public interface IDatabase
    {
        /// <summary>
        /// Tworzy nowy obiekt połączenia z bazą danych.
        /// </summary>
        /// <param name="userName">Nazwa użytkownika</param>
        /// <param name="password">Hasło</param>
        /// <returns>Nowe połączenie do bazy danych</returns>
        IConnection GetNewConnection(string userName, string password);

        /// <summary>
        /// Pobiera dane z bazy.
        /// Rzucane wyjątki:
        /// - ConnectionClosedException - Próba pobrania danych z bazy przy zamkniętym połączeniu.
        /// </summary>
        /// <param name="connection">Połączenie z bazą danych</param>
        /// <returns>Dane
        /// Dane przedstawione są w formie listy dziesięciu słowników. Każdy zawiera trzy klucze: pesel, imie, nazwisko.
        /// Wartości dla kolejnych kluczy to:
        /// - pesel (int): kolejne numery od 0 do 9
        /// - imie (string): Imie_0, Imie_1, ..., Imie_9
        /// - nazwisko (string): Nazwisko_0, Nazwisko_1, ..., Nazwisko_9</returns>
        List<Dictionary<string, object>> GetData(IConnection connection);

        /// <summary>
        /// Zwraca nazwę bazy danych.
        /// </summary>
        /// <returns>Nazwa bazy danych</returns>
        string GetDatabaseName();

       
    }
}
