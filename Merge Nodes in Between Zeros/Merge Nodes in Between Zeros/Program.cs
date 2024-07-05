using Merge_Nodes_in_Between_Zeros;

int[] inputs = { 0, 3, 1, 0, 4, 5, 2, 0 };
ListNode targetNode = new(inputs[0]);
ListNode trackTargetNode = targetNode;

for (int i = 1; i < inputs.Length; i++)
{
    trackTargetNode.next = new(inputs[i]);
    trackTargetNode = trackTargetNode.next;
}

ListNode result = new Solution().MergeNodes(targetNode);

Console.Write("[ " + result.val);
while (result.next is not null)
{
    result = result.next;
    Console.Write(" " + result.val);

}
Console.Write(" ]");