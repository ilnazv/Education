// https://trello.com/c/G2oboCqD/279-perfect-square

using System;

namespace Algorithms.PerfectSquare
{
    public static class PerfectSquareSolutionExample
    {
        public static void Run()
        {
            const int x = 32;

            var result = PerfectSquare.FindDividerToMakePerfectSquare(x);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
