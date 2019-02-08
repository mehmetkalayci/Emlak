using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Helper
{
    public class DateHelper
    {
        public static int GetMonthDifference(DateTime startDate, DateTime endDate)
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            return Math.Abs(monthsApart);
        }

        public static int TotalNumberOfDaysInMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }
    }
}
