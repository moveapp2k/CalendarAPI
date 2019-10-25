using CalendarAPI.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CalendarAPI.Data
{

   

    public class ServerCalendarItem : CalendarItemModel
    {
        public int Id { get; set; }
   
        public  CalendarItemModel ToModel(ServerCalendarItem x) => new CalendarItemModel { Body = x.Body, StartTime = x.StartTime, Title= x.Title };

    }
}
