using System;
using System.Linq;

namespace Algorithms.LargestRectangle
{
    public class LargestRectangle
    {
        public static int GetLargestRectangle(int[] heights)
        {
            var length = heights.Length;

            if (length == 0)
            {
                return 0;
            }

            var minHeight = heights.Min();

            if (length == 1)
            {
                return minHeight;
            }

            var currentRect = minHeight*length;

            var minIndex = Array.IndexOf(heights, minHeight);

            var arrLeft = heights.Take(minIndex).ToArray();
            var arrRight = heights.Skip(minIndex + 1).ToArray();

            var leftRect = GetLargestRectangle(arrLeft);
            var rightRect = GetLargestRectangle(arrRight);

            var rects = new []{ leftRect, rightRect, currentRect};

            var maxRect = rects.Max();

            return maxRect;
        }
    }
}
