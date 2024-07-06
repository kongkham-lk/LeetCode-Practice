using System;
namespace Find_the_Minimum_and_Maximum_Number_of_Nodes_Between_Critical_Points;

public class Solution
{
    public int[] NodesBetweenCriticalPoints(ListNode head)
    {
        List<int> validCritPointList = new(); // initialized the critical point that is either local maxima/minima
        int[] result = new int[] {-1, -1}; // Initialized a default array to return when no valid critical point found

        int headIndex = 0;

        ListNode prev = head;
        head = head.next;

        // iterate through listNode looking for critical point
        while (head.next != null)
        {
            headIndex++;

            if (prev.val < head.val && head.next.val < head.val || prev.val > head.val && head.next.val > head.val)
                validCritPointList.Add(headIndex);

            prev = head;
            head = head.next;
        }

        // Only get the min/max distance when the list has more than two or more valid critical point to find distance
        if (validCritPointList.Count() > 1)
        {
            // Iterate through the list as there might be the case where the index that store some in the middle result in the less distnace
            for (int i = 1; i < validCritPointList.Count(); i++)
            {
                int newMinDistance = validCritPointList[i] - validCritPointList[i - 1];

                // Assign the newMinDistance right away, since the default distance is -1 which should be smallest
                result[0] = (result[0] == -1 || result[0] > newMinDistance) ? newMinDistance : result[0];
            }
            result[1] = validCritPointList.Last() - validCritPointList.First();
        }

        return result;
    }
}

