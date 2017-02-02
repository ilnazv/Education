using System;

namespace Algorithms.LargestRectangle
{
    public static class LargestRectangleSolutionExample
    {
        public static void Run()
        {
            var heights = new[]
            {
                5,3,4,2,6,1,5,5,1,5,5,5
            };

            var result = LargestRectangle.GetLargestRectangle(heights);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
