using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.LinkedList
{
    internal class ReorderListclass
    {
        public void ReorderList(ListNode head)
        {
            Stack<ListNode> nodes = new Stack<ListNode>(); //Nodes
            ListNode current = head;
            int count = 0;
            while (current != null)
            {
                nodes.Push(current);
                count++;
                current = current.next;
            }
            current = head;
            ListNode next;
            for (int i = 0; i < count/2; i++)
            {
                next = current.next;
                current.next = nodes.Pop();
                current = current.next;
                current.next = next;
                current = current.next;
            }
            current.next = null;
            
        }
    }
}
