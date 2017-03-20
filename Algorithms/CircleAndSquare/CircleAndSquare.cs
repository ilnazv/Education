using System;

namespace Algorithms.CircleAndSquare
{
    public static class CircleAndSquare
    {
        public static void Draw(int w, int h, int xc, int yc, int r, int x1, int y1, int x3, int y3)
        {
            var area = new char[h, w];

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    area[j, i] = '.';
                }
            }

            DrawCircle(w, h, xc, yc, r, ref area);
            DrawSquare(w, h, x1, y1, x3, y3, ref area);

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(area[i, j]);
                }

                Console.WriteLine();
            }
        }

        private static void DrawCircle(int w, int h, int xc, int yc, int r, ref char[,] area)
        {
            for (int i = xc - r; i < xc + r + 1; i++)
            {
                for (int j = yc - r; j < yc + r + 1; j++)
                {
                    if (i < 0 || j < 0 || i > w - 1 || j > h - 1)
                    {
                        continue;
                    }

                    var a = Math.Abs(xc - i);
                    var b = Math.Abs(yc - j);

                    bool insideCircle = a*a + b*b <= r*r;

                    if (insideCircle)
                    {
                        area[j, i] = '#';
                    }
                }
            }
        }
        
        private static void DrawSquare(int w, int h, int x1, int y1, int x3, int y3, ref char[,] area)
        {
            var x2 = (x1 + x3) / 2.0 + (y1 - y3) / 2.0;
            var y2 = (y1 + y3) / 2.0 + (x3 - x1) / 2.0;

            var x4 = (x1 + x3) / 2.0 + (y3 - y1) / 2.0;
            var y4 = (y1 + y3) / 2.0 + (x1 - x3) / 2.0;

            var a0 = y1 - y2;
            var b0 = x2 - x1;
            var c0 = x1 * y2 - x2 * y1;

            var a1 = y2 - y3;
            var b1 = x3 - x2;
            var c1 = x2 * y3 - x3 * y2;
            
            var a2 = y3 - y4;
            var b2 = x4 - x3;
            var c2 = x3 * y4 - x4 * y3;

            var a3 = y4 - y1;
            var b3 = x1 - x4;
            var c3 = x4 * y1 - x1 * y4;
            
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    var dotInsideLine0 = Math.Ceiling(a0 * i + b0 * j + c0) < 1;
                    var dotInsideLine1 = Math.Ceiling(a1 * i + b1 * j + c1) < 1;
                    var dotInsideLine2 = Math.Ceiling(a2 * i + b2 * j + c2) < 1;
                    var dotInsideLine3 = Math.Ceiling(a3 * i + b3 * j + c3) < 1;
                    
                    bool insideSquare = dotInsideLine0 && dotInsideLine1 && dotInsideLine2 && dotInsideLine3;
                    
                    if (insideSquare)
                    {
                        area[j, i] = '#';
                    }
                }
            }
        }
    }
}
