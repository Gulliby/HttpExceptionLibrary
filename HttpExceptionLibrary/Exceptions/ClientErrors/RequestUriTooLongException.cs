using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class RequestUriTooLongException : Exception
    {
        public RequestUriTooLongException() : base(HttpExceptionMessages.UriTooLong414)
        {
        }

        public RequestUriTooLongException(string message) : base(message)
        {
        }

        public RequestUriTooLongException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
