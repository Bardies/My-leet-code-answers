using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.Arrays
{
    internal class Trapping_Rain_Water
    {
        //Time Complexity: O(n)
        //Space Complexity: O(n)
        //Key: Min(maxLeft, maxRight) - height[i]
        public int Trap(int[] height)
        {
            int[] maxLeftHeight = new int[height.Length];
            int[] maxRightHeight = new int[height.Length];
            int res = 0;
            int maxLeft = 0, maxRight = 0;
            for (int i = 0; i < height.Length; i++)
            {
                maxLeft = Math.Max(maxLeft, height[i]);
                maxRight = Math.Max(maxRight, height[height.Length-1 - i]);
                maxRightHeight[height.Length -1- i] = maxRight;
                maxLeftHeight[i] = maxLeft;
            }
            int temp;
            for (int i = 0; i < height.Length; i++)
            {
                temp = Math.Min(maxRightHeight[i], maxLeftHeight[i]) - height[i];
                if (temp > 0) res += temp;
            }
            return res;
            
        }
    }
}
