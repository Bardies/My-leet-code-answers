using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    internal class Spiral_Matrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int left = 0, top = 0,
                right = matrix[0].Length, // No of cols in the first row
                bottom = matrix.Length;   //No. of rows

            List<int> result = new List<int>();
            while (left < right && top < bottom)
            {
                //Loop from left to right
                for (int i = left; i < right; i++)
                {
                    result.Add(matrix[top][i]);
                }
                top++;
                //Loop from top to bottom
                for (int i = top; i < bottom; i++)
                {
                    result.Add(matrix[i][right - 1]);
                }
                right--;
                //If the matrix has only one array
                if (!(left < right && top < bottom)) break;

                //Loop From right to left;
                for (int i = right-1; i > left-1; i--)
                {
                    result.Add(matrix[bottom - 1][i]);
                }
                bottom--;
                //Loop from bottom to top
                for (int i = bottom-1 ; i > top-1; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
            return result;
        }
    }
}
