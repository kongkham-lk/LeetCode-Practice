public class Solution {
    public int NumTilings(int n) {
        double[] dp = new double[n+1];
        return SaveDP(n, dp);
    }

    private int SaveDP(int n, double[] dp) {
        if (n <= 1) return 1;
        else if (n == 2) return 2;
        else if (n == 3) return 5;
        for (int i = 0; i <= 3; i++) {
            dp[i] = SaveDP(i, dp);
            Console.WriteLine(i + ": " + dp[i]);
        }
        int MOD = 1000000007;
        for (int i = 4; i <= n; i++) {
            dp[i] = (2 * dp[i-1] + dp[i-3]) % MOD;
            Console.WriteLine(i + ": " + dp[i]);
        }
            
        return (int) dp[n];
    }

}