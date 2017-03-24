using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class LengthRequiredException : Exception
    {
        public LengthRequiredException() : base(HttpExceptionMessages.LengthRequired411)
        {
        }

        public LengthRequiredException(string message) : base(message)
        {
        }

        public LengthRequiredException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
