namespace Algorithms.ChosenOne
{
    public static class ChosenOne
    {
        public static long GetDividerExceptOneNumber(int n, long [] numbers)
        {
            if (n == 1)
            {
                return numbers[0] + 1;
            }

            var commonGcd = CommonGcd(numbers);
            
            for (int i = 0; i < n; i++)
            {
                numbers[i] /= commonGcd;
            }

            var prefixGcdList = new long[n];
            prefixGcdList[0] = numbers[0];

            for (int i = 1; i < n; i++)
            {
                prefixGcdList[i] = Gcd(prefixGcdList[i-1], numbers[i]);
            }

            var suffixGcdList = new long[n];
            suffixGcdList[n - 1] = numbers[n - 1];

            for (int i = n - 2; i >= 0; i--)
            {
                suffixGcdList[i] = Gcd(suffixGcdList[i+1], numbers[i]);
            }

            long prefixGcd = 0;

            for (int i = 1; i < n - 1; i++)
            {
                if (prefixGcdList[i] == 1)
                {
                    if (prefixGcdList[i-1] != 1)
                    {
                        prefixGcd = prefixGcdList[i - 1] * commonGcd;
                        break;
                    }
                }
            }

            long suffixGcd = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (suffixGcdList[i] == 1)
                {
                    suffixGcd = suffixGcdList[i + 1] * commonGcd;
                    break;
                }
            }

            return Gcd(prefixGcd, suffixGcd);
        }

        private static long CommonGcd(long[] numbers)
        {
            var commonGcd = numbers[0];

            for (int j = 0; j < numbers.Length; j++)
            {
                commonGcd = Gcd(commonGcd, numbers[j]);
            }

            return commonGcd;
        }

        private static long Gcd(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;

            return a;
        }
    }
}
