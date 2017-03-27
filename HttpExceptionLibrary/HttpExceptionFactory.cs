using System;
using System.Net;
using HttpExceptionLibrary.Exceptions;
using HttpExceptionLibrary.Exceptions.ClientErrors;
using HttpExceptionLibrary.Exceptions.ServerErrors;

namespace HttpExceptionLibrary
{
    public static class HttpExceptionFactory
    {
        public static Exception Exception(HttpStatusCode httpStatusCode, object obj, string format)
        {
            switch (httpStatusCode)
            {
                case HttpStatusCode.BadRequest:
                    return new BadRequestException(MesageBuilder.Build(obj,format));
                case HttpStatusCode.Unauthorized:
                    return new UnauthorizedException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.PaymentRequired:
                    return new PaymentRequiredException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.Forbidden:
                    return new ForbiddenException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.NotFound:
                    return new NotFoundException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.MethodNotAllowed:
                    return new MethodNotAllowedException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.NotAcceptable:
                    return new NotAcceptableException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.ProxyAuthenticationRequired:
                    return new ProxyAuthenticationRequiredException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.RequestTimeout:
                    return new RequestTimeOutException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.Conflict:
                    return new ConflictException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.Gone:
                    return new GoneException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.LengthRequired:
                    return new LengthRequiredException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.PreconditionFailed:
                    return new PreconditionFailedException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.RequestEntityTooLarge:
                    return new RequestEntityTooLargeException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.RequestUriTooLong:
                    return new RequestUriTooLongException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.UnsupportedMediaType:
                    return new UnsupportedMediaTypeException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.RequestedRangeNotSatisfiable:
                    return new RequestedRangeNotSatisfiableException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.ExpectationFailed:
                    return new ExpectationFailedException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.InternalServerError:
                    return new InternalServerErrorException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.NotImplemented:
                    return new NotImplementedServerException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.BadGateway:
                    return new BadGatewayException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.ServiceUnavailable:
                    return new ServiceUnavailableException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.GatewayTimeout:
                    return new GatewayTimeoutException(MesageBuilder.Build(obj, format));
                case HttpStatusCode.HttpVersionNotSupported:
                    return new HttpVersionNotSupportedException(MesageBuilder.Build(obj, format));
                default:
                    throw new ArgumentOutOfRangeException(nameof(httpStatusCode), httpStatusCode, null);
            }
        }
    }
}
