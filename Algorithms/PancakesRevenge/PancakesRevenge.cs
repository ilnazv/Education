namespace Algorithms.PancakesRevenge
{
    public static class PancakesRevenge
    {
        public static int GetManeuversCountToFlipUpPancakes(string pancakesSides)
        {
            int maneuversCount = 0;

            int lastCakePosition = pancakesSides.Length - 1;

            bool isFlipped = false;

            for (int i = lastCakePosition; i >= 0; i--)
            {
                bool isBlank = pancakesSides[i] == '-';

                if (isBlank && !isFlipped || !isBlank && isFlipped)
                {
                    isFlipped = !isFlipped;
                    maneuversCount++;
                }
            }
            return maneuversCount;
        }
    }
}
