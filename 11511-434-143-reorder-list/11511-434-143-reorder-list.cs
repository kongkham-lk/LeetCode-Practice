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
        // =================== implement recursion ============================//

        // public void ReorderList(ListNode root)
        // {
        //     if (root == null)
        //         return;
        //     ListNode curr = root;
        //     ListNode head = root;
        //     ReorderList(ref head, ref curr);
        // }
    
        // public void ReorderList(ref ListNode head, ref ListNode curr) 
        // {
        //     if (curr == null) return;
            
        //     // use recursive to reversely iterate linked list
        //     ReorderList(ref head, ref curr.next);
            
        //     ListNode tail = curr; // fetch the new tail node
        //     if (head == tail.next) // if tail point back to head node, remove the last node's next pointer
        //         head.next = null;
        //     if (head.next != null)
        //     {
        //         ListNode temp = head;
        //         head = head.next;
        //         temp.next = tail;
        //         temp = temp.next;
        //         temp.next = head;
        //         if (head == tail) // if head point to tail node, remove the last node's next pointer
        //             head.next = null;
        //     }
        // }

        // =================== implement fast slow pointer (more efficient) ==========================//

        public void ReorderList(ListNode root)
        {
            if (root == null || root.next == null || root.next.next == null)
                return;

            ListNode s = root;
            ListNode f = root.next;

            // get mid node of linked list
            while (f != null && f.next != null)
            {
                s = s.next;
                f = f.next.next;
            }

            // swap pointer
            ListNode prev = s;
            s = s.next;

            while (s != null)
            {
                ListNode temp = s;
                s = s.next;
                temp.next = prev;
                prev = temp;
            }

            // Merge head and tail node
            ListNode head = root;
            while (head != prev || head != prev.next)
            {
                ListNode temp = head;
                head = head.next;
                temp.next = prev;
                prev = prev.next;
                temp = temp.next;
                temp.next = head;
                if (head == prev.next)
                {
                    prev.next = null;
                    break;
                }
            }
        }
}