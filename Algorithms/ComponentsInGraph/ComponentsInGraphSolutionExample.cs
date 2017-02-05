// https://trello.com/c/bWvVAPgB/285-components-in-a-graph

using System;
using System.IO;

namespace Algorithms.ComponentsInGraph
{
    public static class ComponentsInGraphSolutionExample
    {
        public static void Run()
        {
            //var binPath = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory);
            //var rootPath = binPath.Parent.Parent.FullName;
            //var inputPath = Path.Combine(rootPath, @"ComponentsInGraph\input.txt");
            //var inputString = "";

            //var n = 0;
            //int[] g;
            //int[] b;
            //using (StreamReader sr = new StreamReader(inputPath))
            //{
            //    n = Convert.ToInt32(sr.ReadLine());
            //    g = new int[n];
            //    b = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        var arr = sr.ReadLine().Split(' ');
            //        g[i] = Convert.ToInt32(arr[0]);
            //        b[i] = Convert.ToInt32(arr[1]);
            //    }
            //}

            var n = 5;
            var g = new int[] { 1, 2, 3, 4, 2 };
            var b = new int[] { 6, 7, 8, 9, 6 };

            var components = new ComponentsInGraph(n, g, b);

            var result = components.GetMinMaxComponents();

            Console.WriteLine(result[0] + " " + result[1]);
            Console.ReadKey();
        }
    }
}
