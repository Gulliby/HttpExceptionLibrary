using System;

namespace HttpExceptionLibrary.Exceptions.ServerErrors
{
    public class NetworkAuthenticationRequiredException : Exception
    {
        public NetworkAuthenticationRequiredException() : base(HttpExceptionMessages.UnsupportedMediaType415)
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
