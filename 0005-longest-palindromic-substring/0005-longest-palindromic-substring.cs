public class Solution {
    public string LongestPalindrome(string s) 
    {
        if (s == null || s.Length == 0)
            return s;

        string result = "";
        List<string> memo = new List<string>();

        for (int i = 0; i < s.Length; i++)
        {
            int l = i;
            int r = i;

            IsPalindrome(s, ref result, l, r, ref memo);

            IsPalindrome(s, ref result, l, r + 1, ref memo);
        }

        return result;
    }

    public bool IsPalindrome(string s, ref string result, int l, int r, ref List<string> memo)
    {
        if (!(l >= 0 && r < s.Length))
            return false;
        else if (memo.Contains(s.Substring(l, r - l + 1)))
            return false;

        if (s.Substring(l, 1).Equals(s.Substring(r, 1)))
        {
            if (result.Length < r - l + 1)
                result = s.Substring(l, r - l + 1);
            if (IsPalindrome(s, ref result, l-1, r+1, ref memo))
                return true;
        }
        else if (!memo.Contains(s.Substring(l, r - l + 1)))
            memo.Add(s.Substring(l, r - l + 1));

        return false;
    }
}