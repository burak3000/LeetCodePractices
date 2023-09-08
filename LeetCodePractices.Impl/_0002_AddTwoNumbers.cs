using System;
using System.Text;

namespace LeetCodePractices.Impl
{
    public static class ListNodeExtensions
    {
        public static string GetAsString(this ListNode node)
        {
            StringBuilder sb = new StringBuilder();
            while (node != null)
            {
                sb.Append(node.val);
                node = node.next;
            }
            return sb.ToString();
        }
    }
    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }



    public class _0002_AddTwoNumbers
    {
        public _0002_AddTwoNumbers()
        {
        }



        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            bool carry = false;
            //Add equal length parts
            int total = l1.val + l2.val;
            int decimalPart = total % 10;
            carry = decimalPart != total;
            ListNode head = new ListNode(decimalPart, null);

            ListNode lastAddedNode = head;
            l1 = l1.next;
            l2 = l2.next;
            while (l1 != null && l2 != null)
            {
                total = l1.val + l2.val;
                if (carry)
                {
                    total++;
                }

                decimalPart = total % 10;
                carry = total != decimalPart;

                ListNode newNode = new ListNode(decimalPart);
                lastAddedNode.next = newNode;
                lastAddedNode = newNode;
                l1 = l1.next;
                l2 = l2.next;

            } 
            //l1 is finished first, add l2
            if (l1 == null)
            {
                 AddRemainingPart(lastAddedNode, l2, carry);
            }
            else
            {
                 AddRemainingPart(lastAddedNode, l1, carry);
            }
            return head;
        }

        private ListNode AddRemainingPart(ListNode iteratorNode, ListNode remainingNode, bool carry)
        {
            while (remainingNode != null)
            {
                int total = carry ? remainingNode.val + 1 : remainingNode.val;
                int decimalPart = total % 10;
                carry = decimalPart != total;
                ListNode currentNode = new ListNode(decimalPart, null);
                iteratorNode.next = currentNode;
                remainingNode = remainingNode.next;
                iteratorNode = currentNode;
            }
            //Add the last carry
            if (carry)
            {
                 iteratorNode.next = new ListNode(1, null);
            }
            return iteratorNode;
        }
    }
}

