using System;
namespace Merge_Nodes_in_Between_Zeros
{
	public class Solution
	{
        public ListNode MergeNodes(ListNode head)
        {
            ListNode newNodeHead = new(head.val);
            if (head.next is null)
                return newNodeHead;

            ListNode currentTrackNode = newNodeHead;
            bool isSetNext = false;

            while (head.next is not null)
            {
                head = head.next;

                if (head.val == 0)
                    isSetNext = true;
                else
                {
                    if (!isSetNext)
                        currentTrackNode.val += head.val;
                    else
                    {
                        currentTrackNode.next = new(head.val);
                        currentTrackNode = currentTrackNode.next;
                        isSetNext = false;
                    }
                }
            }
            return newNodeHead;
        }
    }
}

//int[] inputs = { 0, 3, 1, 0, 4, 5, 2, 0 };
//                              \
// [ 4, 4, null]
//       \