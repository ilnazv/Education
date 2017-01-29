using System.Collections.Generic;

namespace Algorithms.Diagonals
{
    public class Diagonals
    {
        public static IList<string> GetDiagonals(int[,] matrix)
        {
            var lengthX = matrix.GetLength(0);
            var lengthY = matrix.GetLength(1);

            var result = new List<string>();

            var startX = lengthX - 1;
            var startY = 0;

            for (int i = 0; i < lengthX + lengthY - 1; i++)
            {
                string curDiagonal = "";

                var curX = startX;
                var curY = startY;

                while (curX < lengthX && curY < lengthY)
                {
                    curDiagonal += matrix[curX, curY] + " ";

                    curX++;
                    curY++;
                }

                if (startX > 0)
                {
                    startX--;
                }
                else
                {
                    startY++;
                }
                
                result.Add(curDiagonal);
            }

            return result;
        }
    }
}
