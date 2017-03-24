using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class GoneException : Exception
    {
        public GoneException() : base(HttpExceptionMessages.Gone410)
        {
        }

        public GoneException(string message) : base(message)
        {
        }

        public GoneException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
