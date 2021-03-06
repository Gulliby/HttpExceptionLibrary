﻿using System;

namespace HttpExceptionLibrary.Exceptions.ServerErrors
{
    public class InternalServerErrorException : Exception
    {
        public InternalServerErrorException() : base(HttpExceptionMessages.InternalServerError500)
        {
        }

        public InternalServerErrorException(string message) : base(message)
        {
        }

        public InternalServerErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
