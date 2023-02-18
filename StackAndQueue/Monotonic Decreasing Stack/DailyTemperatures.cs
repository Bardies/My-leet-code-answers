using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.StackAndQueue.Monotonic_Decreasing_Stack
{
   
    internal class _DailyTemperatures
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            Stack<StackElement> stack = new Stack<StackElement>();
            int[] res = Enumerable.Repeat(0, temperatures.Length).ToArray();
            for (int i = 0; i < temperatures.Length; i++)
            {
                while (stack.Count != 0 && stack.Peek().Value < temperatures[i])
                {
                    StackElement smallerTemp =  stack.Pop();
                    res[smallerTemp.Position] = i-smallerTemp.Position;
                }
                stack.Push(new StackElement() { Position = i , Value= temperatures[i] });
            }
            return res;
        }
    }
}
