using System;

namespace Algorithms.PerfectSquare
{
    public static class PerfectSquare
    {
        public static int FindDividerToMakePerfectSquare(int x)
        {
            for (int i = 1; i*i <= x; i++)
            {
                if (x % i == 0)
                {
                    var root = Math.Sqrt(x / i);
                    bool isPerfectSquare = root % 1 == 0;

                    if (isPerfectSquare)
                    {
                        return i;
                    }
                }
            }

            return 0;
        }
    }
}
