using System;
using System.Collections.Generic;
using System.Text;

namespace TypeExtensions
{
    public static class DateExtensions
    {
        public static bool IsBetween(this DateTime item, DateTime start, DateTime end)
        {
            return item <= end && item >= start;
        }
    }
}
