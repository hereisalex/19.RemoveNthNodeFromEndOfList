using System;
using System.Collections.Generic;

public class Solution
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public static void Main(string[] args)
    {
        var testList = new ListNode(1);
        var result = RemoveNthFromEnd(testList, 1);
    }
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(0, head);
        ListNode first = dummy;
        ListNode second = dummy;

        for (int i = 1; i <= n + 1; i++)
        {
            first = first.next;
        }

        while (first != null)
        {
            first = first.next;
            second = second.next;
        }

        second.next = second.next.next;
        return dummy.next;
    }
}
