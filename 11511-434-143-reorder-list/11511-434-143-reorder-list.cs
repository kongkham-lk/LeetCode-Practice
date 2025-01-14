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
    public void ReorderList(ListNode head)
        {
            if (head == null)
                return;
            ListNode curr = head;
            ListNode tail = null;
            int count = 1;
            ReverseSecondHalfNodeSet(ref head, ref tail, ref curr, ref count);
            curr = head;
            while (curr != tail && curr != null && tail != null)
            {
                ListNode temp = curr;
                curr = curr.next;
                temp.next = tail;
                temp = temp.next;
                tail = tail.next;
                temp.next = curr;
            }
            
            // set null to next node of the intersect (middle node)
            if (curr == tail)
                curr.next = null;
            else if (curr == null && tail != null)
                tail.next = null;
            else if (tail == null && curr != null)
                curr.next = null;
        }
    
        public void ReverseSecondHalfNodeSet(ref ListNode head, ref ListNode tail, ref ListNode curr, ref int count) 
        {
            if (curr.next == null)
            {
                count = count / 2 - 1;
                tail = curr;
                return;
            }
            count++;
            ReverseSecondHalfNodeSet(ref head, ref tail, ref curr.next, ref count);
            ListNode nextCurr = curr.next;
            if (count > 0) // only reverse point half of the set by using count
            {
                count--;
                nextCurr.next = curr;
                curr.next = null;
            }
            return;
        }
}