using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class UnsupportedMediaTypeException : Exception
    {
        public UnsupportedMediaTypeException() : base(HttpExceptionMessages.UnsupportedMediaType415)
        {
        }

        public UnsupportedMediaTypeException(string message) : base(message)
        {
        }

        public UnsupportedMediaTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
