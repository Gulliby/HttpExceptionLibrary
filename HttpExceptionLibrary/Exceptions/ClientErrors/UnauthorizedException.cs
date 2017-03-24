using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException() : base(HttpExceptionMessages.Unauthorized401)
        {
        }

        public UnauthorizedException(string message) : base(message)
        {
        }

        public UnauthorizedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
