using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarAPI.Messages
{
    public class AuthRequest
    {
        public string UsernameOrEmail {get; set;}
        public string Password { get; set; }

    }
}
