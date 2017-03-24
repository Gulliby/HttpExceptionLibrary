using System;

namespace HttpExceptionLibrary.Exceptions.ServerErrors
{
    public class NotImplementedServerException : Exception
    {
        public NotImplementedServerException() : base(HttpExceptionMessages.NotImplemented501)
        {
        }

        public NotImplementedServerException(string message) : base(message)
        {
        }

        public NotImplementedServerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
