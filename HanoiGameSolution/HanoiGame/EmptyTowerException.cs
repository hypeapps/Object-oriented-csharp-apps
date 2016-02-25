using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{
    class EmptyTowerException : Exception
    {

        public EmptyTowerException() { }
        public EmptyTowerException(string message) : base(message) { }
        public EmptyTowerException(string message, Exception inner) : base(message, inner) { }

        protected EmptyTowerException(System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {


        }
    
    }
}
