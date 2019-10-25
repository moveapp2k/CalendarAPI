using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarAPI.Models
{
    /// <summary>
    /// Models a calendar Item
    /// </summary>
    public class CalendarItemModel
    {
        /// <summary>
        /// The title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The string body of the Calendar Item
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The start time of the calendar item represented in EPOCH MS
        /// </summary>
        public int StartTime { get; set; }


    }
}
