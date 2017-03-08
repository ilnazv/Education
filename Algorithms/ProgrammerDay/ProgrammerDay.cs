using System;

namespace Algorithms.ProgrammerDay
{
    public static class ProgrammerDay
    {
        public static string GetProgrammerDay(int year)
        {
            if (year == 1918)
            {
                return "26.09.1918";
            }

            var day = IsLeapYear(year) ? 12 : 13;
            
            return $"{day}.09.{year}";
        }

        private static bool IsLeapYear(int year)
        {
            if (year <= 1917 && year % 4 == 0)
            {
                return true;
            }

            if (year > 1917 && (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }

            return false;
        }
    }
}
