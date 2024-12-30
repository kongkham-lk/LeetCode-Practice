public class Solution {
    public int ClimbStairs(int n) {
        int[] memo = new int[n + 1];

        for (int i = n; i >= 0; i--)
        {
            if (i == n)
                memo[i] = 1;
            else if (i + 1 == n)
                memo[i] = memo[n];
            else if (memo[i + 1] != 0 && memo[i + 2] != 0)
                memo[i] = memo[i + 1] + memo[i + 2];
        }

        return memo[0];
    }
}