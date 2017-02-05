using System;
using System.Collections.Generic;

namespace Algorithms.ComponentsInGraph
{
    public class ComponentsInGraph
    {
        private int Min;
        private int Max;
        private int N;
        private int[] B;
        private int[] G;
        private bool[] marked;
        private List<int>[] connections;

        public ComponentsInGraph(int n, int[] g, int[] b)
        {
            N = n;
            B = b;
            G = g;
            marked = new bool[N*2+1];
            connections = new List<int>[N*2+1];

            for (int i = 0; i < n*2+1; i++)
            {
                connections[i] = new List<int>();
            }

            for (int i = 0; i < n; i++)
            {
                connections[g[i]].Add(b[i]);
                connections[b[i]].Add(g[i]);
            }
        }

        public int[] GetMinMaxComponents()
        {
            Min = N+1;
            Max = 0;

            for (int i = 0; i < N; i++)
            {
                var size = GetComponentSize(G[i]);

                if (size > 0)
                {
                    Min = Math.Min(Min, size);
                    Max = Math.Max(Max, size);
                }
            }

            return new[] { Min, Max };
        }

        private int GetComponentSize(int startPos)
        {
            if (marked[startPos])
            {
                return 0;
            }

            var components = new Queue<int>();

            marked[startPos] = true;
            var counter = 0;
            var position = startPos;

            components.Enqueue(position);

            while (components.Count > 0)
            {
                position = components.Dequeue();
                counter++;

                foreach (var connection in connections[position])
                {
                    if (!marked[connection])
                    {
                        components.Enqueue(connection);
                        marked[connection] = true;
                    }
                }
            }

            return counter;
        }
    }
}
