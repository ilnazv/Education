// https://trello.com/c/03UnPb5G/280-print-diagonals

using System;

namespace Algorithms.Diagonals
{
    public static class DiagonalsSolutionExample
    {
        public static void Run()
        {
            var inputMatrix = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            var result = Diagonals.GetDiagonals(inputMatrix);

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
