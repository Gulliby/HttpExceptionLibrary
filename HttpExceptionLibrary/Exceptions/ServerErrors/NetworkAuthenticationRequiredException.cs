using System;

namespace HttpExceptionLibrary.Exceptions.ServerErrors
{
    public class NetworkAuthenticationRequiredException : Exception
    {
        public NetworkAuthenticationRequiredException() : base(HttpExceptionMessages.NetworkAuthenticationRequired511)
        {
        }

        public NetworkAuthenticationRequiredException(string message) : base(message)
        {
        }

        public NetworkAuthenticationRequiredException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
