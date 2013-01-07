﻿using System;
using System.Globalization;

namespace NExtra
{
    /// <summary>
    /// This IDateTimeWeekParser implementation can be used to
    /// calculate the week number for a certain date. It makes
    /// use of the native Calendar.GetWeekOfYear method, which
    /// is not always correct for boundary dates.
    /// </summary>
    /// <remarks>
    /// Author:     Daniel Saidi [daniel.saidi@gmail.com]
    /// Link:       http://danielsaidi.github.com/nextra
    /// </remarks>
    public class DateTimeWeekParser : IDateTimeWeekParser
    {
        public DateTimeWeekParser()
            : this(CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
        {
        }

        public DateTimeWeekParser(CalendarWeekRule weekRule, DayOfWeek firstDayOfWeek)
        {
            WeekRule = weekRule;
            FirstDayOfWeek = firstDayOfWeek;
        }


        private DayOfWeek FirstDayOfWeek { get; set; }

        private CalendarWeekRule WeekRule { get; set; }


        public DateTime GetFirstDateOfWeek(DateTime date)
        {
            if (date == DateTime.MinValue)
                return date;

            var week = GetWeekNumber(date);
            while (week == GetWeekNumber(date))
                date = date.AddDays(-1);
            return date.AddDays(1);
        }

        public DateTime GetLastDateOfWeek(DateTime date)
        {
            if (date == DateTime.MaxValue)
                return date;

            var week = GetWeekNumber(date);
            while (week == GetWeekNumber(date))
                date = date.AddDays(1);
            return date.AddDays(-1);
        }

        public virtual int GetWeekNumber(DateTime date)
        {
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, WeekRule, FirstDayOfWeek);
        }
    }
}