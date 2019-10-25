using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarAPI.Messages
{
    public interface IRequireTokenRequest
    {
        public string Token { get; set; }
    }
}
