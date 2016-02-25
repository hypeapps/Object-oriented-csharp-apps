using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTest
{
    class ConnectionAlreadyClosedException : Exception
    {
        public ConnectionAlreadyClosedException() { }
        public ConnectionAlreadyClosedException(string message) : base(message) { }
        public ConnectionAlreadyClosedException(string message, Exception inner) : base(message, inner) { }

        protected ConnectionAlreadyClosedException(System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {


        }

    }
}
