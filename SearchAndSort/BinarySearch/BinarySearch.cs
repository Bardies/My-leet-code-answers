using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.SearchAndSort.BinarySearch
{
    internal class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            int mid ;
            while (left <= right) // equal because if we have 1 element.
            {
                mid = left + ((right - left) / 2);
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
