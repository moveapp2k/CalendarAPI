using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CalendarAPI.Messages
{
    /// <summary>
    /// Represents a base response with the  HTTP Status code
    /// </summary>
    public class GenericResponse
    {
        public HttpStatusCode Status { get; set; }
    }
}
