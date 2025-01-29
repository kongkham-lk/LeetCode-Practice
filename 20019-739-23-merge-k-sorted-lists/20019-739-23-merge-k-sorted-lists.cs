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
    public ListNode MergeKLists(ListNode[] lists) {
        if (!lists.Any())
            return null;

        ListNode res = new ListNode();
        while (lists.Length > 1)
        {
            List<ListNode> tempList = new List<ListNode>();
            int i = 0;
            for (i = 0; i < lists.Length; i += 2)
            {
                ListNode l1 = lists[i];
                ListNode l2 = i + 1 < lists.Length ? lists[i + 1] : null;
                tempList.Add(MergeNodes(l1, l2));
            }
            lists = tempList.ToArray();
        }

        return lists[0];
    }

    public ListNode MergeNodes(ListNode l1, ListNode l2)
    {
        ListNode res = new ListNode();
        ListNode curr = res;
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                curr.next = l1;
                l1 = l1.next;
            }
            else
            {
                curr.next = l2;
                l2 = l2.next;
            }
            curr = curr.next;
        }

        if (l1 != null)
            curr.next = l1;
        if (l2 != null)
            curr.next = l2;
        
        return res.next;
    }
}