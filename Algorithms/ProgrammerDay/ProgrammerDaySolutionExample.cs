//https://trello.com/c/cehWNdiw/293-day-of-the-programmer

using System;

namespace Algorithms.ProgrammerDay
{
    public static class ProgrammerDaySolutionExample
    {
        public static void Run()
        {
            int inputYear0 = 1900;
            int inputYear1 = 1918;
            int inputYear2 = 1990;

            var day0 = ProgrammerDay.GetProgrammerDay(inputYear0);
            var day1 = ProgrammerDay.GetProgrammerDay(inputYear1);
            var day2 = ProgrammerDay.GetProgrammerDay(inputYear2);

            Console.WriteLine("Year: " + inputYear0 + "; Date: " + day0);
            Console.WriteLine("Year: " + inputYear1 + "; Date: " + day1);
            Console.WriteLine("Year: " + inputYear2 + "; Date: " + day2);
            Console.ReadKey();
        }
    }
}
