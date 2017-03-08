using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BigSorting
{
    public class BigSorting
    {
        public string[] SortArray(string[] array)
        {
            var myComparer = new MyComparer();
            Array.Sort(array, myComparer);

            return array;
        }
    }

    public class MyComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            int aLength = a.Length;
            int bLength = b.Length;

            if (aLength > bLength)
            {
                return 1;
            }

            if (aLength < bLength)
            {
                return -1;
            }

            for (int i = 0; i < aLength; i++)
            {
                if (a[i] > b[i])
                {
                    return 1;
                }

                if (b[i] > a[i])
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
