using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.SearchAndSort.BinarySearch
{
    public class Searcha2DMatrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int[] arr = new int[matrix.Length * matrix[0].Length];
            int idx = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    arr[idx++] = matrix[i][j];
                }
            }
            int left = 0, right = arr.Length - 1, mid;
            while (left <= right) // equal because if we have 1 element.
            {
                mid = left + ((right - left) / 2);
                if (arr[mid] == target) return true;
                else if (arr[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return false;
        }
    }
}
