using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.LinkedList
{
  public class ListNode {
      public int val;
     public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }
 
    internal class ReverseLinkedlist
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode currentNode = head;
            ListNode temp, next;
            while (currentNode.next != null)
            {
                next = currentNode.next;
                temp = currentNode.next;
                currentNode.next = prev;
                prev = temp;
                currentNode = next;
            }
            return currentNode.next;
        }
    }
}
