using System;

namespace HttpExceptionLibrary.Exceptions.ServerErrors
{
    public class NotImplementedServerException : Exception
    {
        public NotImplementedServerException() : base(HttpExceptionMessages.UnsupportedMediaType415)
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
