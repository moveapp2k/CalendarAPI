using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CalendarAPI.Messages
{
    public class AuthResponse : GenericResponse
    {
        public string Token { get; set; }
    }
}
