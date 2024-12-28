public class Solution {
    public int FindDuplicate(int[] nums) {
        ISet<int> memo = new HashSet<int>();

        foreach (int num in nums)
        {
            if (memo.Contains(num))
                return num;

            memo.Add(num);
        }

        return -1;
    }
}