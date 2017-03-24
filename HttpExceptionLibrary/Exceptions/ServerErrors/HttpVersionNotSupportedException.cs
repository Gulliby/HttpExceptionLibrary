using System;

namespace HttpExceptionLibrary.Exceptions.ServerErrors
{
    public class HttpVersionNotSupportedException : Exception
    {
        public HttpVersionNotSupportedException() : base(HttpExceptionMessages.UnsupportedMediaType415)
        {
        }

        public HttpVersionNotSupportedException(string message) : base(message)
        {
        }

        public HttpVersionNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
