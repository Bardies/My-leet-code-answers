using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.StackAndQueue.Monotonic_Decreasing_Stack
{
    internal class NextGreaterElementI
    {
        public int[] HashTableNextGreaterElement(int[] nums1, int[] nums2) // O(n^2)
        {
            // Brute force solution using hash table
            //1. nums1 => hashtable
            //2. loop over nums2 
            //for each value in nums2 if it exits in nums1 => loop
            //   for each value from next value in nums2 to the end check if it's greater  or not
            //      if greater => add in the same index of the value in nums1 the index of the geater value in nums2
            Hashtable nums1HashTable = new Hashtable();
            int[] res = Enumerable.Repeat(-1, nums1.Length).ToArray();
            for (int i = 0; i < nums1.Length; i++) //O(m): m length of nums1
            {
                nums1HashTable.Add(i, nums1[i]);
            }
            for (int i = 0; i < nums2.Length; i++) // O(n^2): n length of nums2
            {
                if (nums1HashTable.ContainsValue(nums2[i]))
                {
                    for (int j = i+1; j < nums2.Length; j++)
                    {
                        if (nums2[j] > nums2[i]) {
                          int idx =  nums1HashTable.Keys.OfType<int>().FirstOrDefault(s => (int)nums1HashTable[s] == nums2[i]);
                            res[idx] = nums2[j];
                            break;
                        }
                    }
                }
            }
            return res;
        }
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            //1. HashMap for nums1
            Hashtable nums1HashTable = new Hashtable();
            int[] res = Enumerable.Repeat(-1, nums1.Length).ToArray();
            for (int i = 0; i < nums1.Length; i++) //O(m): m length of nums1
            {
                nums1HashTable.Add(i, nums1[i]);
            }
            //Monotonic decreasing stack
            Stack<int> nums2Stack = new Stack<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                int current = nums2[i];
                while (nums2Stack.Count > 0 && nums2Stack.Peek() < current)
                {
                    int smallerValue = nums2Stack.Pop();
                    int smallerValueIdx = nums1HashTable.Keys.OfType<int>().FirstOrDefault(s => (int)nums1HashTable[s] == smallerValue);
                    //Add in its idx the value that kicked it out of the stack, it's the next greater.
                    res[smallerValueIdx] = current;
                }
                //Push in stack if it's empty / value less than top
                if (nums1HashTable.ContainsValue(current))
                {
                    nums2Stack.Push(current);
                }
            }
            return res;
        }
        }
}
