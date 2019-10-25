using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.Globalization;
using CalendarAPI.Data;
using CalendarAPI.Models;
using CalendarAPI.Messages;

namespace CalendarAPI.Services
{
  
    /// <summary>
    /// Stores the result of a calendar operation
    /// </summary>
    public class CalendarOperationResult : GenericResponse
    {
        public string[] Errors { get; set; }
        public OperationResult Result { get; set; }
        public IEnumerable<ServerCalendarItem> Payload { get; set; }
    }

    public class CalendarService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task <CalendarOperationResult> AddCalendarItem(int userId, CalendarItemModel item)
        {
            await Task.Run(() => 1 + 1);
            return new CalendarOperationResult { Result = OperationResult.SUCCESS, Errors = new string[] { }, Payload = new ServerCalendarItem[] {  }  }; 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<CalendarOperationResult> GetCalendarItem(int[] calendarItemIds)
        {
            await Task.Run(() => 1 + 1);

            return new CalendarOperationResult { Result = OperationResult.SUCCESS, Errors = new string[] { },  Payload = new ServerCalendarItem[] { } };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="calendarItemId"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<CalendarOperationResult> UpdateCalendarItem(int calendarItemId, CalendarItemModel item)
        {
            await Task.Run(() => 1 + 1);

            return new CalendarOperationResult { Result = OperationResult.SUCCESS, Errors = new string[] { }, Payload = new ServerCalendarItem[] { } };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="calendarItemIds"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<CalendarOperationResult> RemoveCalendarItems(int[] calendarItemIds)
        {
            await Task.Run(() => 1 + 1);

            return new CalendarOperationResult { Result = OperationResult.SUCCESS, Errors = new string[] { }, Payload = new ServerCalendarItem[] { } };
        }

    }
}
