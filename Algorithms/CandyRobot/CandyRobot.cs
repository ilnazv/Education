namespace Algorithms.CandyRobot
{
    public static class CandyRobot
    {
        public static int GetTotalNumberOfCandies(int n, int t, int[] b)
        {
            int total = 0;
            int remains = n;

            for (int i = 0; i < t-1; i++)
            {
                remains -= b[i];

                if (remains < 5)
                {
                    total += n - remains;
                    remains = n;
                }
            }

            return total;
        }
    }
}
