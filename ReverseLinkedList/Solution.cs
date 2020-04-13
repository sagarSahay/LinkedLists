using Common;

namespace ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            var current = head;
            ListNode prev = null;

            while (current!=null)
            {
                var tmp = current.next;
                current.next = prev;
                prev = current;
                current = tmp;
            }

            return prev;
        }
    }
}