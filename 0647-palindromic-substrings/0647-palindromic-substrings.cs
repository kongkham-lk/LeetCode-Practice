public class Solution {
    public int CountSubstrings(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int l = i;
            int r = i;
            count += GetPalindrome(s, l, r) + GetPalindrome(s, l, r + 1);
        }

        return count;
    }

    private int GetPalindrome(string s, int l, int r)
    {
        int count = 0;
        while (l >= 0 && r < s.Length && s.Substring(l, 1).Equals(s.Substring(r, 1)))
        {
            l--;
            r++;
            count++;
        }

        return count;
    }
}