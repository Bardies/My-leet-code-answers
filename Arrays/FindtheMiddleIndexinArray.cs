using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.Arrays
{
    internal class FindtheMiddleIndexinArray
    {
        //Brute force
        public int FindMiddleIndex(int[] nums)
        {
            int middleIdx = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                int sumBefore = 0, sumAfter = 0;
                for (int j = i+1; j < nums.Length; j++)
                {
                    sumAfter += nums[j];
                }
                for (int k = 0; k < i; k++)
                {
                    sumBefore += nums[k];
                }
                if (sumBefore == sumAfter)
                {
                    middleIdx = i;
                    break;
                }
            }
            return middleIdx;
        }
    }
}
