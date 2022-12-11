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
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>(); //Key: number, value: indicies (multi value).
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    List<int> keys = dic[nums[i]];
                    for (int j = 0; j < keys.Count; j++)
                    {
                        if (Math.Abs(i - keys[j]) <= k) return true;
                    }
                    //Add distinct keys 
                    dic[nums[i]].Add(i);

                }
                else dic.Add(nums[i], new List<int>() { i }); //Create new entry in the dictionary
            }
            return false;
        }
    }
}
