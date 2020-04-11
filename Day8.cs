using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAprilChallenge
{
    public class Day8
    {
        public ListNode MiddleNode(ListNode head)
        {
            var current = head;
            var count = 0;
            while (current != null)
            {
                current = current.next;
                count++;
            }
            for (var i = 0; i < count / 2; i++)
            {
                head = head.next;
            }
            return head;
        }
    }
}
