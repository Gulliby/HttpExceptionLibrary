using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class RequestTimeOutException : Exception
    {
        public RequestTimeOutException() : base(HttpExceptionMessages.RequestTimeOut408)
        {
        }

        public RequestTimeOutException(string message) : base(message)
        {
        }

        public RequestTimeOutException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
