using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.SearchAndSort.BinarySearch
{
    internal class KokoEatingBananas
    {
        //Out of memory!!!!!!
        public static int MinEatingSpeed(int[] piles, int h)
        {
            //K: bananas eaten / hour
            int maxK = piles.Max(pile => pile); //11
            List<int> possibleK = new List<int>();
            for (int i = 1; i < maxK+1; i++)//1 to 11
            {
                possibleK.Add(i);
            }

            int left = 1, right = maxK, res = right, currentHours = 0, k;
            while (left <= right) // equal because if we have 1 element.
            {
                currentHours = 0;
                k = left + ((right - left) / 2);
                for (int i = 0; i < piles.Length; i++)
                {
                    currentHours += (int)Math.Ceiling((decimal)piles[i]/k);
                }
                if (currentHours > h)
                {
                    left = k + 1;
                }
                else if (currentHours <= h)
                {
                    res = Math.Min(res, k);
                    right = k - 1;
                }
                
            }
            return res;

        }

    }
}
