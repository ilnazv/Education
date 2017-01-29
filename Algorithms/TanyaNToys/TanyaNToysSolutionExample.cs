// https://trello.com/c/ByPzGNyf/208-tanya-and-toys

using System;

namespace Algorithms.TanyaNToys
{
    public static class TanyaNToysSolutionExample
    {
        public static void Run()
        {
            var toysCount = 4;
            var money = 14;
            var inputToys = new[] { 4, 6, 12, 8 };

            var result = TanyaNToys.GetToys(toysCount, money, inputToys);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
