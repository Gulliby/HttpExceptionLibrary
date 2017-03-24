using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class ExpectationFailedException : Exception
    {
        public ExpectationFailedException() : base(HttpExceptionMessages.ExpectationFailed417)
        {
        }

        public ExpectationFailedException(string message) : base(message)
        {
        }

        public ExpectationFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
