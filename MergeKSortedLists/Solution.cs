using System.Linq;
using Common;

namespace MergeKSortedLists
{
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var amount = lists.Length;
            var interval = 1;

            while (interval < amount)
            {
                for (int i = 0; i < amount - interval; i = interval * 2)
                {
                    lists[i] = Merge2Lists(lists[i], lists[interval + i]);
                }

                interval *= 2;
            }

            return lists[0];
        }

        private ListNode Merge2Lists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);
            var point = head;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    point.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    point.next = l2;
                    l2 = l1;
                    l1 = point.next.next;
                }

                point = point.next;
            }

            if (l1 == null)
            {
                point.next = l2;
            }
            else
            {
                point.next = l1;
            }

            return head.next;
        }

        // public ListNode MergeKLists(ListNode[] lists)
        // {
        //     var list = new List<int>();
        //
        //     foreach (var node in lists)
        //     {
        //         var curr = node;
        //         while (curr != null)
        //         {
        //             list.Add(curr.val);
        //             curr = curr.next;
        //         }
        //     }
        //
        //     list.Sort();
        //
        //     var point = new ListNode(0);
        //     var head = point;
        //
        //     foreach (var val in list)
        //     {
        //         var node = new ListNode(val);
        //         point.next = node;
        //         point = point.next;
        //     }
        //
        //     return head.next;
        // }
    }
}