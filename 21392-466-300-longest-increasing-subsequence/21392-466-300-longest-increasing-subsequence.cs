public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] dp = new int[nums.Length];
        
        // for dynamic programming, each el must initialize its default value first
        for (int i = 0; i < dp.Length; i++)
            dp[i] = 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                    dp[i] = Math.Max(dp[i], 1 + dp[j]);
            }
        }

        return dp.Max();
    }
}