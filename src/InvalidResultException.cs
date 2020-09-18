using System;
using System.Collections.Generic;
using System.Text;

namespace monaco_chess.src
{
    class InvalidResultException : System.Exception
    {
        public InvalidResultException() : base() { }
        public InvalidResultException(string message) : base(message) { }
        public InvalidResultException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected InvalidResultException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
