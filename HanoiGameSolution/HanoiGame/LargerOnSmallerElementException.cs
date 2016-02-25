using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{
    class LargerOnSmallerElementException : Exception
    {

        public LargerOnSmallerElementException() { }
        public LargerOnSmallerElementException(string message) : base(message) { }
        public LargerOnSmallerElementException(string message, Exception inner) : base(message, inner) { }

        protected LargerOnSmallerElementException(System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {


        }
    }
}
