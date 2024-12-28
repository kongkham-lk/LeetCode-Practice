public class Solution {
    public int SingleNumber(int[] nums) {
            List<int> memo = new List<int>();
            foreach (int num in nums)
            {
                if (memo.Contains(num))
                    memo.Remove(num);
                else
                    memo.Add(num);
            }

            return memo[0];
    }
}