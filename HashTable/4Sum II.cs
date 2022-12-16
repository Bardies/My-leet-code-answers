using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.HashTable
{
    public static class _4Sum_II
    {
        public static int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
        {
            int count = 0;
            Dictionary<int, int> sumOfTwoNumbers = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for(int j = 0; j  < nums2.Length; j++)
                {
                    if (sumOfTwoNumbers.ContainsKey(nums1[i] + nums2[j]))
                        sumOfTwoNumbers[nums1[i] + nums2[j]]++;
                    else
                        sumOfTwoNumbers.Add(nums1[i] + nums2[j], 1);
                }
            }
            for (int i = 0; i < nums3.Length; i++)
            {
                for (int j = 0; j < nums4.Length; j++)
                {
                    if (sumOfTwoNumbers.ContainsKey(-(nums3[i] + nums4[j])))
                        count+= sumOfTwoNumbers[ -(nums3[i] + nums4[j])];
                }
            }
            return count;

        }
    }
}
