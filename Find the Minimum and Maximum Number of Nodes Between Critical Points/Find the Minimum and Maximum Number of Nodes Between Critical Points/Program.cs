using Find_the_Minimum_and_Maximum_Number_of_Nodes_Between_Critical_Points;

int[] inputs = { 1, 3, 2, 2, 3, 2, 2, 2, 7 };
ListNode targetNode = new(inputs[0]);
ListNode trackTargetNode = targetNode;

for (int i = 1; i < inputs.Length; i++)
{
    trackTargetNode.next = new(inputs[i]);
    trackTargetNode = trackTargetNode.next;
}

ListNode result = targetNode;

Console.WriteLine("Input LinkList: ");
Console.Write("[ " + result.val);
while (result.next is not null)
{
    result = result.next;
    Console.Write(" " + result.val);

}
Console.WriteLine(" ]\n");

int[] validCriticalDistances = new Solution().NodesBetweenCriticalPoints(targetNode);

Console.WriteLine("Return distance of crital point min/max: ");
Console.WriteLine($"[ {validCriticalDistances[0]} {validCriticalDistances[1]} ]");