// https://trello.com/c/OePoGGpu/281-pie-progress

using System;

namespace Algorithms.PieProgress
{
    public static class PieProgressSolutionExample
    {
        public static void Run()
        {
            var pieProgressSolver = new PieProgress();

            #region Case #0

            const int m0 = 3;
            const int n0 = 2;

            int[][] inputCosts0 =
            {
                new[] {1, 1},
                new[] {100, 100},
                new[] {10000, 10000}
            };

            var result0 = pieProgressSolver.SolveCase(m0, n0, inputCosts0);

            Console.WriteLine("Case #0: " + result0);

            #endregion

            #region Case #1

            const int m1 = 10;
            const int n1 = 4;

            int[][] inputCosts1 =
            {
                new[] {7, 15, 12, 6},
                new[] {15, 3, 19, 18},
                new[] {10, 9, 10, 14},
                new[] {12, 14, 8, 8},
                new[] {5, 3, 5, 11},
                new[] {9, 14, 19, 11},
                new[] {12, 6, 20, 9},
                new[] {18, 13, 12, 15},
                new[] {14, 14, 10, 20},
                new[] {11, 19, 12, 11}
            };

            var result1 = pieProgressSolver.SolveCase(m1, n1, inputCosts1);

            Console.WriteLine("Case #1: " + result1);

            #endregion

            Console.ReadKey();
        }
    }
}
