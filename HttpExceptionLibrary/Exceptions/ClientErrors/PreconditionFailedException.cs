using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class PreconditionFailedException : Exception
    {
        public PreconditionFailedException() : base(HttpExceptionMessages.PreconditionFailed412)
        {
        }

        public PreconditionFailedException(string message) : base(message)
        {
        }

        public PreconditionFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
