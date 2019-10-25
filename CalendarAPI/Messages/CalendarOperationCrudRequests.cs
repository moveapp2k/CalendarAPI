using CalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
///  Holds all of the request classes for the calendar controller in one file for the sake of example
/// </summary>
namespace CalendarAPI.Messages
{
    public class AddToCalendarRequest : IRequireTokenRequest
    {
        public string Token { get; set; }
        public CalendarItemModel CalendarItem { get; set; }
        public int UserId { get; set; }
    }
    public class ReadCalendarItemRequest : IRequireTokenRequest
    {
        public string Token { get; set; }
        /// <summary>
        /// List of Ids to return, might be a good idea to somehow limit this
        /// </summary>
        public int[] CalendarItemIds { get; set; }
    }
    public class UpdateCalendarItemRequest : IRequireTokenRequest
    {
        public string Token { get; set; }
        public int CalendarItemId { get; set; }
        public CalendarItemModel CalendarItem { get; set; }
        
    }
    public class RemoveCalendarRequest : ReadCalendarItemRequest
    {
        // add some crazy stuff here
        
    }
}
