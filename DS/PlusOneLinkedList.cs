using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class PlusOneLinkedList
    {
        public ListNode PlusOne(ListNode head)
        {
            if(head == null)
                return new ListNode(0);
            AddAndPassCarryOver(head);
            return new ListNode(0);
        }

        private int AddAndPassCarryOver(ListNode head)
        {
            
            if(head == null)
                return 0;
            if(head.next == null)
            {
                head.val = (head.val + 1) % 9;
                if (head.val == 0)
                    return 1;
            }
            return head.val + AddAndPassCarryOver(head.next);
        }

       
    }
}
