using System;

namespace Algorithms.CountSheep
{
    public static class CountSheep
    {
        private static bool[] _numbersMarked;

        public static string GetLastSeenNumber(long n)
        {
            _numbersMarked = new bool[10];
            var step = 1;
            long curNumber = 0;
            while (!AllNumbersIsMarked())
            {
                curNumber = step * n;
                MarkNumber(curNumber);
                step++;
                if (NumberIsIncorrect(curNumber))
                {
                    return "INSOMNIA";
                }
            }

            return curNumber.ToString();
        }

        private static void MarkNumber(long number)
        {
            var strNumber = number.ToString().ToCharArray();

            foreach (var c in strNumber)
            {
                _numbersMarked[(int)Char.GetNumericValue(c)] = true;
            }
        }

        private static bool AllNumbersIsMarked()
        {
            foreach (var number in _numbersMarked)
            {
                if (!number)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool NumberIsIncorrect(long number)
        {
            return number == 0 || number > 1000000;
        }
    }
}
