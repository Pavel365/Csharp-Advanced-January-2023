using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public static class DateModifier
    {
        public static int GetDifferenceInDays(string start, string end)
        {
            DateTime startDateTime = DateTime.Parse(start);
            DateTime endDateTime = DateTime.Parse(end);

            TimeSpan difference = endDateTime - startDateTime;

            return Math.Abs(difference.Days);
        }
    }
}
