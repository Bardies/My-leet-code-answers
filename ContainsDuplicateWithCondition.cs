using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    internal static class ContainsDuplicateWithCondition
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Hashtable hashtable = new Hashtable(); //Key: index(can't be duplicated), Value: number.
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashtable.ContainsValue(nums[i]))
                {
                    //Hash table contains the value, it can be in more than one index
                    List<int> keysOfDuplicatedValue = hashtable.Keys.OfType<int>().Where(s => (int)hashtable[s] == nums[i]).ToList();
                    for (int j = 0; j < keysOfDuplicatedValue.Count; j++)
                    {
                        if (Math.Abs(i - keysOfDuplicatedValue[j]) <= k) return true;
                    }
                    //Add distinct keys 
                    hashtable.Add(i, nums[i]);

                }
                else hashtable.Add(i, nums[i]);
            }
            return false;
        }
    }
}
