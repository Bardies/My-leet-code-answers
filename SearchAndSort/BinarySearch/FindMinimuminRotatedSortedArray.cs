using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.SearchAndSort.BinarySearch
{
    internal class FindMinimuminRotatedSortedArray
    {
        //Recursive sol
        private int Search(int[] nums, int l, int r)
        {
            if (l == r) return nums[l];
            int mid = l + (r - l) / 2;
            if (nums[mid] < nums[r]) return Search(nums, mid + 1, r);
            else if (nums[mid] > nums[r]) return Search(nums,l,  mid);
            return nums[r];

        }
        public int FindMin(int[] nums)
        {
            return Search(nums, 0, nums.Length-1);
        }
    }
}
