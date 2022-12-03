using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code
{
    internal class Unique_Number_Of_Ocuurence
    {
        //Time Complexity: O(n), n is length of arr
        public bool UniqueOccurrences(int[] arr)
        {
            //Using Dictionary key is number and value is count of number.
            Dictionary<int, int> dic   = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i])) dic[arr[i]]++;
                else dic.Add(arr[i], 1);
            }
            return dic.Values.Count == dic.Values.ToList().Distinct().Count();
           
        }
    }
}
