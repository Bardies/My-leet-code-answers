using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.StackAndQueue.Monotonic_Decreasing_Stack
{
    internal class SlidingWindowMaximum
    {
        //Brute force (Time limit Exceed)
        public int[] BruteForceMaxSlidingWindow(int[] nums, int k)
        {
            int iterations = nums.Length - k + 1;
            int[] res = new int[iterations];
            for (int i = 0; i < iterations; i++)
            {
                int max = nums[i];
                for (int j = i; j < k+i; j++)
                {
                    max = Math.Max(max, nums[j]);
                }
                res[i] = max;
            }
            return res;
        }
        //Monotonic decreasing queue (NOT COMPLETED!!!!!!!!)
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int iterations = nums.Length - k + 1;
            int[] res = new int[iterations];
            int l = 0, r = 0; //(from left to right)
            Queue<int> queue = new Queue<int>();
            //We don't reach the end of the array
            while (r < nums.Length)  
            {
                //Monotonic decreasing
                //Pop smaller values than the one we are comparing to add it
                while (queue.Count != 0 && queue.Peek() < nums[r])
                {
                    queue.Dequeue();
                }
                //Add the index of value
                queue.Enqueue(r);

                //Remove left val from queue (out of bound of the current menu)
                //and If left in window is larger than the first element in queue no need to the value in queue as we get max
                
            }
            return res;

        }
    }
}
