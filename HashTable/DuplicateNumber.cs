using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.HashTable
{
    internal class DuplicateNumber
    {
        public int FindDuplicate(int[] nums)
        {
            Hashtable numbers = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numbers.ContainsKey(nums[i])) return nums[i];
                numbers.Add(nums[i], i);
            }
            return 0;
        }
    }
}
