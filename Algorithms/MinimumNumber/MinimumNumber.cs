namespace Algorithms.MinimumNumber
{
    public static class MinimumNumber
    {
        public static string GetMinFunction(int n)
        {
            var result = "int";

            var count = n-1;

            while (count > 0)
            {
                result = GetMinStr(result);
                count--;
            }

            return result;
        }

        private static string GetMinStr(string currentStr)
        {
            return "min(int, " + currentStr + ")";
        }
    }
}
