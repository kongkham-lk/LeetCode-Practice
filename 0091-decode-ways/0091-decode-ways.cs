public class Solution {
    public int NumDecodings(string s) 
    {
        int dp1 = 1, dp2 = 0;

        for (int i = 0; i < s.Length; i++)
        {
            string one = s.Substring(i, 1);
            int dp = one.Equals("0") ? 0 : dp1;
            if (i > 0)
            {
                string two = s.Substring(i - 1, 1);
                if (two.Equals("1") || two.Equals("2") && int.Parse(one.ToString()) < 7)
                    dp += dp2;
            }
            dp2 = dp1;
            dp1 = dp;
        }

        return dp1;
    }
}