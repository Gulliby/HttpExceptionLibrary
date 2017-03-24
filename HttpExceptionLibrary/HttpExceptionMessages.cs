namespace HttpExceptionLibrary
{
    public static class HttpExceptionMessages
    {
        #region Client Errors

        /// <summary>
        /// Gets the bad request400.
        /// </summary>
        /// <value>
        /// The bad request400.
        /// </value>
        public static string BadRequest400 { get; } = "The request cannot be fulfilled due to bad syntax";
        
        /// <summary>
        /// Gets the unauthorized401.
        /// </summary>
        /// <value>
        /// The unauthorized401.
        /// </value>
        public static string Unauthorized401 { get; } = "The request was a legal request, but the server is refusing to respond to it. For use when authentication is possible but has failed or not yet been provided";

        /// <summary>
        /// Gets the payment required402.
        /// </summary>
        /// <value>
        /// The payment required402.
        /// </value>
        public static string PaymentRequired402 { get; } = "Reserved for future use";

        /// <summary>
        /// Gets the forbidden403.
        /// </summary>
        /// <value>
        /// The forbidden403.
        /// </value>
        public static string Forbidden403 { get; } = "The request was a legal request, but the server is refusing to respond to it";

        /// <summary>
        /// Gets the not found404.
        /// </summary>
        /// <value>
        /// The not found404.
        /// </value>
        public static string NotFound404 { get; } = "The requested page could not be found but may be available again in the future";

        /// <summary>
        /// Gets the method not allowed405.
        /// </summary>
        /// <value>
        /// The method not allowed405.
        /// </value>
        public static string MethodNotAllowed405 { get; } = "A request was made of a page using a request method not supported by that page";

        /// <summary>
        /// Gets the not acceptable406.
        /// </summary>
        /// <value>
        /// The not acceptable406.
        /// </value>
        public static string NotAcceptable406 { get; } = "	The server can only generate a response that is not accepted by the client";

        /// <summary>
        /// Gets the proxy authentication required407.
        /// </summary>
        /// <value>
        /// The proxy authentication required407.
        /// </value>
        public static string ProxyAuthenticationRequired407 { get; } = "The client must first authenticate itself with the proxy";

        /// <summary>
        /// Gets the request time out408.
        /// </summary>
        /// <value>
        /// The request time out408.
        /// </value>
        public static string RequestTimeOut408 { get; } = "The server timed out waiting for the request";

        /// <summary>
        /// Gets the conflict409.
        /// </summary>
        /// <value>
        /// The conflict409.
        /// </value>
        public static string Conflict409 { get; } = "The request could not be completed because of a conflict in the request";

        /// <summary>
        /// Gets the gone410.
        /// </summary>
        /// <value>
        /// The gone410.
        /// </value>
        public static string Gone410 { get; } = "The requested page is no longer available";

        /// <summary>
        /// Gets the length required411.
        /// </summary>
        /// <value>
        /// The length required411.
        /// </value>
        public static string LengthRequired411 { get; } = "The \"Content-Length\" is not defined. The server will not accept the request without it ";

        /// <summary>
        /// Gets the precondition failed412.
        /// </summary>
        /// <value>
        /// The precondition failed412.
        /// </value>
        public static string PreconditionFailed412 { get; } = "The precondition given in the request evaluated to false by the server";

        /// <summary>
        /// Gets the payload too large413.
        /// </summary>
        /// <value>
        /// The payload too large413.
        /// </value>
        public static string PayloadTooLarge413 { get; } = "The server will not accept the request, because the request entity is too large";

        /// <summary>
        /// Gets the URI too long414.
        /// </summary>
        /// <value>
        /// The URI too long414.
        /// </value>
        public static string UriTooLong414 { get; } = "The server will not accept the request, because the URL is too long. Occurs when you convert a POST request to a GET request with a long query information ";

        /// <summary>
        /// Gets the unsupported media type415.
        /// </summary>
        /// <value>
        /// The unsupported media type415.
        /// </value>
        public static string UnsupportedMediaType415 { get; } = "The server will not accept the request, because the media type is not supported";

        /// <summary>
        /// Gets the range not satisfiable416.
        /// </summary>
        /// <value>
        /// The range not satisfiable416.
        /// </value>
        public static string RangeNotSatisfiable416 { get; } = "The client has asked for a portion of the file, but the server cannot supply that portion";

        /// <summary>
        /// Gets the expectation failed417.
        /// </summary>
        /// <value>
        /// The expectation failed417.
        /// </value>
        public static string ExpectationFailed417 { get; } = "The server cannot meet the requirements of the Expect request-header field";

        #endregion

        #region Server Errors

        /// <summary>
        /// Gets the internal server error500.
        /// </summary>
        /// <value>
        /// The internal server error500.
        /// </value>
        public static string InternalServerError500 { get; } = "A generic error message, given when no more specific message is suitable";

        /// <summary>
        /// Gets the not implemented501.
        /// </summary>
        /// <value>
        /// The not implemented501.
        /// </value>
        public static string NotImplemented501 { get; } = "The server either does not recognize the request method, or it lacks the ability to fulfill the request";

        /// <summary>
        /// Gets the bad gateway502.
        /// </summary>
        /// <value>
        /// The bad gateway502.
        /// </value>
        public static string BadGateway502 { get; } = "The server was acting as a gateway or proxy and received an invalid response from the upstream server";

        /// <summary>
        /// Gets the service unavailable503.
        /// </summary>
        /// <value>
        /// The service unavailable503.
        /// </value>
        public static string ServiceUnavailable503 { get; } = "The server is currently unavailable (overloaded or down)";

        /// <summary>
        /// Gets the gateway timeout504.
        /// </summary>
        /// <value>
        /// The gateway timeout504.
        /// </value>
        public static string GatewayTimeOut504 { get; } = "The server was acting as a gateway or proxy and did not receive a timely response from the upstream server";

        /// <summary>
        /// Gets the HTTP version not supported505.
        /// </summary>
        /// <value>
        /// The HTTP version not supported505.
        /// </value>
        public static string HttpVersionNotSupported505 { get; } = "The server does not support the HTTP protocol version used in the request";

        /// <summary>
        /// Gets the network authentication required511.
        /// </summary>
        /// <value>
        /// The network authentication required511.
        /// </value>
        public static string NetworkAuthenticationRequired511 { get; } = "The client needs to authenticate to gain network access";

        #endregion
    }
}
