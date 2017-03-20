//https://trello.com/c/IixhOv44/297-candy-replenishing-robot

using System;

namespace Algorithms.CandyRobot
{
    public static class CandyRobotSolutionExample
    {
        public static void Run()
        {
            const int n = 8;
            const int t = 4;

            int[] b = { 3, 1, 7, 5 };

            var result = CandyRobot.GetTotalNumberOfCandies(n, t, b);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
