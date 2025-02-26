public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
            bool[] dp = new bool[s.Length + 1];
            dp[s.Length] = true;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                foreach (string w in wordDict)
                {
                    if ((i + w.Length) <= s.Length && // since start from the back, skip all the char until the distance of i and s.length == w.length
                        s.Substring(i, w.Length).Equals(w))
                        dp[i] = dp[i + w.Length];

                    if (dp[i])
                        break;
                }
            }

            return dp[0];
    }
}