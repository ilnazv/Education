//https://trello.com/c/gdHNjaiZ/294-big-sorting

using System;

namespace Algorithms.BigSorting
{
    public static class BigSortingSolutionExample
    {
        public static void Run()
        {
            var inputArray = new[]
            {
                "6",
                "31415926535897932384626433832795",
                "1",
                "3",
                "10",
                "3",
                "5"
            };

            var solver = new BigSorting();
            var result = solver.SortArray(inputArray);
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
