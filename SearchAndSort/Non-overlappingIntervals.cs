using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.SearchAndSort
{
    internal class Non_overlappingIntervals
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            var sortedByFisrtVal = intervals.OrderBy(y => y[0]).ToList();
            int count = 0;
            int previousEnd = sortedByFisrtVal[0][1];
            for (int i = 1; i < sortedByFisrtVal.Count; i++)
            {
               if(sortedByFisrtVal[i][0] >= previousEnd)
                {
                    //no overlap

                    previousEnd = sortedByFisrtVal[i][1];             }
                else
                {
                    count++;
                    previousEnd = Math.Min(previousEnd, sortedByFisrtVal[i][1]);
                }

            }
            return count;
        }
    }
}
