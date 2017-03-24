using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class RequestEntityTooLargeException : Exception
    {
        public RequestEntityTooLargeException() : base(HttpExceptionMessages.PayloadTooLarge413)
        {
        }

        public RequestEntityTooLargeException(string message) : base(message)
        {
        }

        public RequestEntityTooLargeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
