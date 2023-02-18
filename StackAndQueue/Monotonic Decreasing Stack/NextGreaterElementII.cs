using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Leet_Code.StackAndQueue.Monotonic_Decreasing_Stack
{
    internal class StackElement
    {
        public int Position { get; set; }
        public int Value { get; set; }
    }
    internal class NextGreaterElementII
    {
        
        public int[] NextGreaterElements(int[] nums)
        {
            Stack<StackElement> stack = new Stack<StackElement>();
            int[] circularNums = new int[nums.Length*2];
            for (int i = 0; i < nums.Length*2; i++)
            {
                circularNums[i] = nums[i % nums.Length];
            }
            int[] res = Enumerable.Repeat(-1, nums.Length).ToArray();
            for(int i = 0; i < circularNums.Length; i++)
            {
                while (stack.Count != 0 && stack.Peek().Value < circularNums[i])
                {
                    StackElement smallerVal = stack.Pop();
                    res[smallerVal.Position] = circularNums[i];
                }
                //All items poped from the stack has its output so we are just searching for a value larger than them to pop them from the array.
                if (i < nums.Length)
                    stack.Push(new StackElement { Position = i, Value = nums[i] });
            }
            return res;
        }
    }
}
