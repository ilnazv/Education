// https://trello.com/c/ELeQfsHv/215-anagrams

using System;
using System.Collections.Generic;

namespace Algorithms.Anagrams
{
    public static class AnagramsSolutionExample
    {
        public static void Run()
        {
            var inputList = new List<string>
            {
                "tea",
                "ate",
                "eat",
                "apple",
                "java",
                "vaja",
                "cut",
                "utc"
            };

            var result = Anagrams.GetAnagrams(inputList);

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
