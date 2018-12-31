using System;
using System.Collections.Generic;
using System.Text;

namespace racer.Shared
{
    public class CalendarDay
    {
        public int Day { get; set; }
        public bool Invalid { get; set; }
        public CalendarEvent[] Events { get; set; }
        public CalendarDay(int day, bool invalid = false)
        {
            Day = day;
            Invalid = invalid;
            Events = Array.Empty<CalendarEvent>();
        }
    }

    public class CalendarEvent
    {
        public string Name { get; set; }
        public string Stage { get; set; }
    }
}
