public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int l = 0, r = 1;
        while (r < prices.Length)
        {
            if (prices[l] < prices[r])
                maxProfit = Math.Max(maxProfit, prices[r] - prices[l]);
            else
                l = r;
            r++;
        }
        return maxProfit;
    }
}