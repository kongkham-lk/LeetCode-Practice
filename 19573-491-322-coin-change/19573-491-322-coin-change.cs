public class Solution {
    public int CoinChange(int[] coins, int amount) {
            int[] memo = new int[amount + 1];

            for (int i = 0; i <= amount; i++)
                memo[i] = amount + 1;

            memo[0] = 0;
            
            for (int a = 1; a <= amount; a++)
            {
                foreach (var coin in coins)
                {
                    int subt = a - coin;
                    if (subt >= 0)
                        memo[a] = Math.Min(memo[a], 1 + memo[subt]);
                }
            }

            return memo[amount] != amount + 1 ? memo[amount] : -1;
    }
}