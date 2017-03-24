using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base(HttpExceptionMessages.NotFound404)
        {
        }

        public NotFoundException(string message) : base(message)
        {
        }

        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
