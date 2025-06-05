public class Solution {
    public int MaxVowels(string s, int k) {
        int l = 0;
        int r = 0;
        int res = 0;
        int max = res;
        string vow = "aeiou";
        while (r < s.Length) {
            Console.Write(s[l] + ", " + s[r] + ", ");
            if (vow.Contains(s[r])) {
                res++;
            }
            if (vow.Contains(s[l]) && res > 0 && r-l >= k)
                res--;
            max = Math.Max(res, max);
            Console.WriteLine(res);
            r++;
            if (r > k)
                l++;
        }
        return max;
    }
}