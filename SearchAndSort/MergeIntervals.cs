using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.SearchAndSort
{
    internal class MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            var sortedByFisrtVal = intervals.OrderBy(y => y[0]).ToList();
            List<List<int>> res = new List<List<int>>();
            res.Add(sortedByFisrtVal[0].ToList());
            for (int i = 0; i < intervals.Length; i++)
            {
                if (sortedByFisrtVal[i][0] <= res[res.Count - 1][1])
                {
                    res[res.Count - 1][1] = Math.Max(sortedByFisrtVal[i][1], res[res.Count - 1][1]);
                    res[res.Count - 1][0] = Math.Min(sortedByFisrtVal[i][0], res[res.Count - 1][0]);
                }
                else res.Add(sortedByFisrtVal[i].ToList());
            }
            return res.Select(a => a.ToArray()).ToArray();
        }
    }
}
