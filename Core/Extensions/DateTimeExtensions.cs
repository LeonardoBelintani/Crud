using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime GetNextDayOfWeek(this DateTime dateTime)
        {
            var handlingDate = dateTime;

            while (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
                handlingDate = handlingDate.AddDays(1);

            return handlingDate;
        }
    }
}
