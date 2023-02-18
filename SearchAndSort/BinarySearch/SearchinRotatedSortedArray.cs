using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.SearchAndSort.BinarySearch
{
    internal class SearchinRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int[] orginal = new int[nums.Length];
            Array.Copy(nums, orginal, nums.Length);
            Array.Sort(nums);
            int left = 0, right = nums.Length - 1;
            int mid;
            while (left <= right) // equal because if we have 1 element.
            {
                mid = left + ((right - left) / 2);
                if (nums[mid] == target) return Array.IndexOf(orginal, target);
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
