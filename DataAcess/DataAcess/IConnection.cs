using System;

namespace DataAccessTest
{
    public interface IConnection: IDisposable
    {
        /// <summary>
        /// Otwiera połączenie z bazą danych
        /// Rzucane wyjątki:
        /// - ConnectionAlreadyOpenedException - Połączenie było już otwarte.
        /// - AuthenticationException - Użytkownik podał niewłaściwe dane uwierzytelniające (poprawne to: username = "asdf", password = "123")
        /// </summary>
        void Open();

        /// <summary>
        /// Zamyka połączenie z bazą danych
        /// Rzucane wyjątki:
        /// - ConnectionAlreadyClosedException - Połączenie nie było otwarte.
        /// </summary>
        void Close();

        /// <summary>
        /// Informacja o statusie połączenia. True - otwarte, false - zamknięte.
        /// </summary>
        /// <returns>Status połączenia</returns>
        bool IsOpen();

        /// <summary>
        /// Zwraca informację o nazwie użytkownika.
        /// </summary>
        /// <returns>Nazwa użytkownika</returns>
        string GetUsername();

        /// <summary>
        /// Zwraca informację o haśle użytkownika.
        /// </summary>
        /// <returns>Hasło</returns>
        string GetPassword();

        /// <summary>
        /// Baza danych, z którą nawiązane jest połączenie.
        /// </summary>
        IDatabase Database { get; }

    }
}
