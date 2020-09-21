using System;
using System.Runtime.Serialization;

namespace monaco_chess.src
{
    [Serializable]
    internal class NoSuchElementException : Exception
    {
        public NoSuchElementException() : base() { }
        public NoSuchElementException(string message) : base(message) { }
        public NoSuchElementException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected NoSuchElementException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}