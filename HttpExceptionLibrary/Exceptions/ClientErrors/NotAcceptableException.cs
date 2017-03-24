using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class NotAcceptableException : Exception
    {
        public NotAcceptableException() : base(HttpExceptionMessages.NotAcceptable406)
        {
        }

        public NotAcceptableException(string message) : base(message)
        {
        }

        public NotAcceptableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
