using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class ForbiddenException : Exception
    {
        public ForbiddenException() : base(HttpExceptionMessages.Forbidden403)
        {
        }

        public ForbiddenException(string message) : base(message)
        {
        }

        public ForbiddenException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
