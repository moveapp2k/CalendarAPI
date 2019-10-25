using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalendarAPI.Messages;
using CalendarAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
namespace CalendarAPI.Controllers
{
    /// <summary>
    /// Web Api Controller
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class WebCalandarController : ControllerBase
    {
       

        private readonly ILogger<WebCalandarController> _logger;

        public WebCalandarController(ILogger<WebCalandarController> logger)
        {
            _logger = logger;
        }

      
        /// <summary>
        /// Authenticates a user using a password flow
        /// </summary>
        /// <param name="calendar">Reference to the Calendar Service defined in startup</param>
        /// <param name="calendarUserService">Reference to the CalendarUserService defined in startup</param>
        /// <param name="clientid">a header value for identitifying a client</param>
        /// <param name="authRequest">a model fo the authentication request</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<ActionResult<AuthResponse>> Auth( 
            [FromServices] CalendarService calendar
            , [FromServices] CalendarUserService calendarUserService
            , [FromHeader] string clientid
            , [FromBody] AuthRequest authRequest)
        {
            // Require a client id for security
            if (string.IsNullOrEmpty(clientid))
            {
               
                return new AuthResponse { Status = HttpStatusCode.BadRequest };
            }

            return new AuthResponse { Status = HttpStatusCode.OK, Token = "Hello World!" };
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<GenericResponse>> Create(
              [FromServices] CalendarService calendar
            , [FromServices] CalendarUserService calendarUserService
            , [FromHeader] string clientid
            , [FromBody] AddToCalendarRequest apiReq)
        {
            // ... check for nulls, validate token etc
            return await calendar.AddCalendarItem(apiReq.UserId, apiReq.CalendarItem);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<GenericResponse>> Read(
              [FromServices] CalendarService calendar
            , [FromServices] CalendarUserService calendarUserService
            , [FromHeader] string clientid
            , [FromBody] ReadCalendarItemRequest apiReq)
        {
            // ... check for nulls, validate token etc

            return await calendar.GetCalendarItem(apiReq.CalendarItemIds);

        }

        [HttpPost("[action]")]
        public async Task<ActionResult<GenericResponse>> Update(
              [FromServices] CalendarService calendar
            , [FromServices] CalendarUserService calendarUserService
            , [FromHeader] string clientid
            , [FromBody] UpdateCalendarItemRequest apiReq)
        {
            // ... check for nulls, validate token etc

            return await calendar.UpdateCalendarItem(apiReq.CalendarItemId, apiReq.CalendarItem);

        }

        [HttpPost("[action]")]
        public async Task<ActionResult<GenericResponse>> Delete(
              [FromServices] CalendarService calendar
            , [FromServices] CalendarUserService calendarUserService
            , [FromHeader] string clientid
            , [FromBody] RemoveCalendarRequest apiReq)
        {
            // ... check for nulls, validate token etc

            return await calendar.RemoveCalendarItems(apiReq.CalendarItemIds);

        }

    }
}
