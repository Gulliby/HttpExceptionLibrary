using System;

namespace HttpExceptionLibrary.Exceptions.ServerErrors
{
    public class ServiceUnavailableException : Exception
    {
        public ServiceUnavailableException() : base(HttpExceptionMessages.UnsupportedMediaType415)
        {
        }

        public ServiceUnavailableException(string message) : base(message)
        {
        }

        public ServiceUnavailableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
