using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class ConflictException : Exception
    {
        public ConflictException() : base(HttpExceptionMessages.Conflict409)
        {
        }

        public ConflictException(string message) : base(message)
        {
        }

        public ConflictException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
