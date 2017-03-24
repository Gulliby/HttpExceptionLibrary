using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class MethodNotAllowedException : Exception
    {
        public MethodNotAllowedException() : base(HttpExceptionMessages.MethodNotAllowed405)
        {
        }

        public MethodNotAllowedException(string message) : base(message)
        {
        }

        public MethodNotAllowedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
