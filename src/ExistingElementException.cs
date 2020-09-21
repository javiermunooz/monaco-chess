using System;
using System.Runtime.Serialization;

namespace monaco_chess.src
{
    [Serializable]
    internal class ExistingElementException : Exception
    {
        public ExistingElementException() : base() { }
        public ExistingElementException(string message) : base(message) { }
        public ExistingElementException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected ExistingElementException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}