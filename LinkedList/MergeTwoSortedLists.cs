using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Leet_Code.LinkedList
{
    internal class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode headOfMergedList, currentNodeInMergedList;
            headOfMergedList = new ListNode();
            currentNodeInMergedList = headOfMergedList;
            //Get the first node to get the head
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    currentNodeInMergedList.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    currentNodeInMergedList.next = list2;
                    list2 = list2.next;
                }
                currentNodeInMergedList = currentNodeInMergedList.next;
            }
            if (list1 == null || list2 == null)
            {
                if (list1 == null)
                {
                    currentNodeInMergedList.next = list2;
                }
                else if (list2 == null)
                {
                    currentNodeInMergedList.next = list1;
                }
            }
            return headOfMergedList;
        }
       
    }
}
