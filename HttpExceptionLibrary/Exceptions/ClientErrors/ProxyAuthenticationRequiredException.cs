using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class ProxyAuthenticationRequiredException: Exception
    {
        public ProxyAuthenticationRequiredException() : base(HttpExceptionMessages.ProxyAuthenticationRequired407)
        {
        }

        public ProxyAuthenticationRequiredException(string message) : base(message)
        {
        }

        public ProxyAuthenticationRequiredException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
