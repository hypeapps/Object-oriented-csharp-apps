using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTest
{
    public class Connection : IConnection

    {
        private string password;
        private string username;
        private IDatabase database;
        private bool isOpen;
        bool disposed = false;
       
        public Connection(string userName, string password, IDatabase database)
        {
            this.username = userName;
            this.password = password;
            this.database = database;
        }

        public void Open()
        {
            
            if (isOpen)
            {
                Exception connectionAlreadyOpenedExpection = new ConnectionAlreadyOpenedException("Połączenie było już otwarte");
                throw connectionAlreadyOpenedExpection;
            }

            if ((username == "asdf") && (password == "123"))
            {
                this.isOpen = true;
            }
            else
            {
                Exception authenticationException = new AuthenticationException("Użytkownik podał niewłaściwe dane uwierzytelniające");
                throw authenticationException;
            }

            Dispose();
            
        }

        public void Close()
        {
            if (!isOpen)
            {
                Exception connectionAlreadyClosedException = new ConnectionAlreadyClosedException("Połączenie nie było otwarte.");
                throw connectionAlreadyClosedException;
            }
            else {
                this.isOpen = false;
            }

            Dispose();
            
        }

        public bool IsOpen()
        {
            return isOpen;
        }

        public string GetUsername()
        {
            return this.username;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public IDatabase Database
        {
            get
            {
                return this.database;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return; 
            if (disposing)
            { 
            }
            
            disposed = true;
        }
    }
}
