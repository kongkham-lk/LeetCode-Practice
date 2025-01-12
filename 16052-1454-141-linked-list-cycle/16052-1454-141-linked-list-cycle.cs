/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
            ISet<ListNode> memo = new HashSet<ListNode>();
            while (head != null)
            {
                if (memo.Contains(head))
                    return true;

                memo.Add(head);
                head = head.next;
            }

            return false;
    }
}