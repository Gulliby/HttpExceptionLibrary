using System;

namespace HttpExceptionLibrary.Exceptions.ServerErrors
{
    public class ServiceUnavailableException : Exception
    {
        public ServiceUnavailableException() : base(HttpExceptionMessages.ServiceUnavailable503)
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
