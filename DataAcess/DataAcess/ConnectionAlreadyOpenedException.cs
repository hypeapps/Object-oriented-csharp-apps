using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTest
{
    [Serializable]
    class ConnectionAlreadyOpenedException : Exception
    {
        public ConnectionAlreadyOpenedException() { }
        public ConnectionAlreadyOpenedException(string message) : base(message) { }
        public ConnectionAlreadyOpenedException(string message, Exception inner) : base(message, inner) { }
        
        protected ConnectionAlreadyOpenedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) {

              
            }
    }
}
