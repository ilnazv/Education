using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.TanyaNToys
{
    public static class TanyaNToys
    {
        public static IList<int> GetToys(int toysCount, int money, int[] toysList)
        {
            Array.Sort(toysList);

            int currentToy = 1;

            var result = new List<int>();

            while (money >= currentToy)
            {
                bool haveThisToy = toysList.Contains(currentToy);

                if (!haveThisToy)
                {
                    result.Add(currentToy);
                    money -= currentToy;
                }

                currentToy++;
            }

            return result;
        }
    }
}
