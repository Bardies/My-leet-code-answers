using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.HashTable
{
    internal class MissingNumberInTheRange
    {
        //Time Complexity: O(2n)
        public int MissingNumber(int[] nums) 
        {
            //Create Hash table with numbers in array O(n)
            Hashtable hashTable = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                hashTable.Add(i, nums[i]);
            }
            //i => number in range => search for it in hashtable  O(n+1)
            for (int i = 0; i < nums.Length+1; i++)
            {
                if (!hashTable.ContainsValue(i)) { 
                    return i;
                }
            }
            return 0;
        }
    }
}
