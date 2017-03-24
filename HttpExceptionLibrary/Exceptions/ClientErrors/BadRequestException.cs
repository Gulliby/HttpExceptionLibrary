using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class BadRequestException: Exception
    {
        public BadRequestException() : base(HttpExceptionMessages.BadRequest400)
        {
        }

        public BadRequestException(string message) : base(message)
        {
        }

        public BadRequestException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
