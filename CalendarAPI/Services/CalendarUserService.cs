using CalendarAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarAPI.Services
{


    public class CalendarUserAuthResult
    {
        public OperationResult OperationResult;
        public string Token { get; set; }
    }

    /// <summary>
    /// A service used to access persistence for calendar users
    /// </summary>
    public class CalendarUserService
    {
        /// <summary>
        /// returns a CalendarUserAuthResult with a token if the user exists
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password </param>
        /// <returns>a CalendarUserAuthResult with a token if the user exists</returns>
        public CalendarUserAuthResult AuthenticateCredentials (string username, string password)
        {
            // Do some actual auth
            return new CalendarUserAuthResult { OperationResult = OperationResult.SUCCESS, Token = "Hello World!" };
        }

        public CalendarUser GetUserFromToken (string Token)
        {
            return new CalendarUser { Username = "ObviouslyFakeExampleUser" };
        }
    }
}
