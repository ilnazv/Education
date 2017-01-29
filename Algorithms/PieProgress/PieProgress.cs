using System;

namespace Algorithms.PieProgress
{
    public class PieProgress
    {
        public int SolveCase(int n, int m, int[][] costs)
        {
            Heap heap = new Heap(m*n);

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                var costsForDay = CalcResCosts(costs[i]);

                for (int j = 0; j < m; j++)
                {
                    heap.Insert(costsForDay[j]);
                }

                result += heap.Remove().getvalue();
            }

            return result;
        }

        private int[] CalcResCosts(int[] costsForDay)
        {
            Array.Sort(costsForDay);

            for (int i = 0; i < costsForDay.Length; i++)
            {
                costsForDay[i] = costsForDay[i] + (int)Math.Pow(i+1, 2) - (int)Math.Pow(i, 2);
            }

            return costsForDay;
        }
    }
}
