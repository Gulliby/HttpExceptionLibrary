using System;

namespace HttpExceptionLibrary.Exceptions
{
    public class PaymentRequiredException : Exception
    {
        public PaymentRequiredException() : base(HttpExceptionMessages.BadRequest400)
        {
        }

        public PaymentRequiredException(string message) : base(message)
        {
        }

        public PaymentRequiredException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
