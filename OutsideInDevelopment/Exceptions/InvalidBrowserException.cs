using System;
using System.Runtime.Serialization;

namespace OutsideInDevelopment
{
    [Serializable]
    internal class InvalidBrowserException : Exception
    {
        public InvalidBrowserException()
        {
        }

        public InvalidBrowserException(string message) : base(message)
        {
        }

        public InvalidBrowserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidBrowserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}