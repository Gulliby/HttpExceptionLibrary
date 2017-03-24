using System;

namespace HttpExceptionLibrary.Exceptions.ClientErrors
{
    public class RequestedRangeNotSatisfiableException : Exception
    {
        public RequestedRangeNotSatisfiableException() : base(HttpExceptionMessages.RangeNotSatisfiable416)
        {
        }

        public RequestedRangeNotSatisfiableException(string message) : base(message)
        {
        }

        public RequestedRangeNotSatisfiableException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
