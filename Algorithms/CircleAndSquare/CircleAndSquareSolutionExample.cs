//https://trello.com/c/zHLhWlY9/295-a-circle-and-a-square

using System;

namespace Algorithms.CircleAndSquare
{
    public static class CircleAndSquareSolutionExample
    {
        public static void Run()
        {
            var w = 30;
            var h = 20;
            var xc = 28;
            var yc = 4;
            var r = 1;
            var x1 = 3;
            var y1 = 14;
            var x3 = 25;
            var y3 = 13;

            CircleAndSquare.Draw(w, h, xc, yc, r, x1, y1, x3, y3);
            Console.ReadKey();
        }
    }
}
