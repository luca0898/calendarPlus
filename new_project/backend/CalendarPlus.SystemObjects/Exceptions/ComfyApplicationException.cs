using System;
using System.Net;

namespace CalendarPlus.SystemObjects.Exceptions
{
    public class CalendarPlusApplicationException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public CalendarPlusApplicationException(
            string message,
            HttpStatusCode statusCode = HttpStatusCode.BadRequest
            ) : base(message)
        {
            StatusCode = statusCode;
        }

        public CalendarPlusApplicationException(
            string message,
            Exception exception,
            HttpStatusCode statusCode = HttpStatusCode.BadRequest
            ) : base(message, exception)
        {
            StatusCode = statusCode;
        }
    }
}
