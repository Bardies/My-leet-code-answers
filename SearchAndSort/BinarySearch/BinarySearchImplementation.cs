using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.SearchAndSort
{
    internal class BinarySearchImplementation
    {
        //Time Complexity: Log(n).
        //Used if and only if the array is sorted.
        public bool IterativeBinarySearch(int[] arr, int x)
        {
            int left = 0, right = arr.Length -1, mid;
            while (left <= right) // equal because if we have 1 element.
            {
                mid = left + ((right - left) / 2);
                if (arr[mid] == x) return true;
                else if (arr[mid] > x)
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
        public bool RecursiveBinarySearch(int[] arr, int x)
        {
            return RecursiveBinarySearchImplementation(arr, x, 0, arr.Length);
        }
        private bool RecursiveBinarySearchImplementation(int[] arr, int x, int left, int right)
        {
            if (left > right) return false;
            // int mid = (left + right) / 2; 
            //To avoid int overflow as if left is max int and right is max int, their addition may cause stack overflow exception
            int mid = left + ((right - left) / 2);
            if (arr[mid] == x) return true;
            else if (arr[mid] > x)
            {
                RecursiveBinarySearchImplementation(arr, x, left, mid - 1);
            }
            else
            {
                RecursiveBinarySearchImplementation(arr, x, mid + 1, right);
            }
            return false;
        }
    }
}
