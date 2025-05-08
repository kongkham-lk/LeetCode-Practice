public class Solution {
    const int MOD = (int)1e9 + 7;
    double[] dp;

    public int NumTilings(int n) {
        dp = new double[n+1];
        return SaveDP(n);
    }

    private int SaveDP(int n) {
        if (n <= 1) return 1;
        else if (n == 2) return 2;
        else if (n == 3) return 5;

        for (int i = 0; i <= 3; i++)
            dp[i] = SaveDP(i);
            
        for (int i = 4; i <= n; i++)
            dp[i] = (2 * dp[i-1] + dp[i-3]) % MOD;
            
        return (int)dp[n];
    }

}