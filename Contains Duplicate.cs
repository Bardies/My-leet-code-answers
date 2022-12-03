using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    internal class Contains_Duplicate
    {
        public bool ContainsDuplicateLINQ(int[] nums) //I don't know how C# implement distinct. 
        {
            return nums.Length != nums.Distinct().Count();
        }
        public bool ContainsDuplicate(int[] nums) //Faster in runtime andd alittle bit large in memory.
        {
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashtable.ContainsKey(nums[i])) return true;
                else hashtable.Add(nums[i], 1);
            }
            return false;
        }
    }
}
