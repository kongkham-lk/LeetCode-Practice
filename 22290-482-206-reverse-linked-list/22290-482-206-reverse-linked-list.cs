/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null)
            return null;
        ListNode prev = head;
        ListNode curr = prev.next;
        prev.next = null;
        while (curr != null)
        {
            ListNode temp = curr;
            curr = temp.next;
            temp.next = prev;
            prev = temp;
        }
        curr = prev;
        return curr;
    }
}