public class Solution {
    public int CountSubstrings(string s)
    {
        List<string> count = new List<string>();

        for (int i = 0; i < s.Length; i++)
        {
            int l = i;
            int r = i;
            GetPalindrome(s, l, r, count);
            GetPalindrome(s, l, r + 1, count);
        }

        return count.Count;
    }

    private void GetPalindrome(string s, int l, int r, List<string> count)
    {
        if (!(l >= 0 && r < s.Length))
            return;
        if (!s.Substring(l, 1).Equals(s.Substring(r, 1)))
            return;

        while (l >= 0 && r < s.Length && s.Substring(l, 1).Equals(s.Substring(r, 1)))
        {
            count.Add(s.Substring(l, r - l + 1));
            l--;
            r++;
        }
    }
}