using System;

namespace HttpExceptionLibrary.Exceptions.ServerErrors
{
    public class GatewayTimeoutException : Exception
    {
        public GatewayTimeoutException() : base(HttpExceptionMessages.GatewayTimeOut504)
        {
        }

        public GatewayTimeoutException(string message) : base(message)
        {
        }

        public GatewayTimeoutException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
