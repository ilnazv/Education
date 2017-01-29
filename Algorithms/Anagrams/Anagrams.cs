using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Anagrams
{
    public static class Anagrams
    {
        public static IList<string> GetAnagrams(IList<string> inputList)
        {
            var result = new List<string>();
            var map = new Dictionary<string, List<int>>();

            for (int i = 0; i < inputList.Count; i++)
            {
                var key = GetKey(inputList[i]);

                if (!map.ContainsKey(key))
                {
                    map[key] = new List<int>();
                }

                map[key].Add(i);
            }

            foreach (var mapKey in map.Keys)
            {
                if (map[mapKey].Count > 1)
                {
                    foreach (var i in map[mapKey])
                    {
                        result.Add(inputList[i]);
                    }
                }
            }

            return result;
        }

        static string GetKey(string str)
        {
            var chars = str.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}
