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
public class Solution 
{
    //===================== Using Recursion =====================//

    // public ListNode RemoveNthFromEnd(ListNode root, int n) {
    //     if (root.next == null && n == 1) return null;

    //     ListNode head = root;
    //     ListNode targetEl = RemoveEl(ref head, ref n);
        
    //     if (targetEl != null) // targetEl not null when no prev and next to link together
    //         return targetEl.next;

    //     return root;
    // }

    // public ListNode RemoveEl(ref ListNode root, ref int n) {
    //     if (root == null)
    //         return null;

    //     ListNode targetEl = RemoveEl(ref root.next, ref n);
    //     n--;
    //     if (n == 0) // found target node to remove
    //         return root;
    //     if (targetEl != null) {
    //         root.next = targetEl.next;
    //         targetEl = null;
    //     }
            
    //     return targetEl;
    // }
    
    //===================== Using Pointers version 1 =====================//

    // public ListNode RemoveNthFromEnd(ListNode root, int n) 
    // {
    //     if (root.next == null && n == 1) return null;
    //     ListNode r = root;
    //     ListNode l = null;
    //     int size = 0;
    //     int N = n;
    //     n++;
    //     while (r != null) {
    //         n--;
    //         r = r.next;
    //         if (n == 0)
    //             l = root;
    //         else if (n < 0)
    //             l = l.next;
    //         size++;
    //     }
    //     if (l == null) {
    //         l = root;
    //         if (size - N == 0)
    //             return l.next;
    //     }
    //     l.next = l.next.next;
    //     return root;
    // }

    //===================== Using Pointers (Refactored) =====================//

    public ListNode RemoveNthFromEnd(ListNode root, int n) 
    {
        ListNode res = new ListNode(0, root);
        ListNode l = res;
        ListNode r = root;

        while (n > 0) {
            r = r.next;
            n--;
        }

        while (r != null) {
            r = r.next;
            l = l.next;
        }

        l.next = l.next.next;

        // need to return res.next instead of root because 
        // if the very first node is removed, it will be handle corretly
        return res.next; 
    }
}