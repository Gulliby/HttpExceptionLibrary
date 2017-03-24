using System;

namespace HttpExceptionLibrary.Exceptions.ServerErrors
{
    public class BadGatewayException : Exception
    {
        public BadGatewayException() : base(HttpExceptionMessages.UnsupportedMediaType415)
        {
        }

        public BadGatewayException(string message) : base(message)
        {
        }

        public BadGatewayException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
