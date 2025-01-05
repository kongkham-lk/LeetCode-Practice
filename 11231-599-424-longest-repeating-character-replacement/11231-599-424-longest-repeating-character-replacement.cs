public class Solution {
    public int CharacterReplacement(string s, int k) {
            int[] temp = new int[26];
            int l = 0;
            int r = 0;
            int res = 0;
            while (r < s.Length)
            {
                temp[s[r] - 'A']++;
                int tempMaxOccur = temp.Max();
                int charLength = r - l + 1;
                if (charLength - tempMaxOccur <= k) {
                    res = Math.Max(res, charLength);
                    r++;
                }
                else
                {
                    temp[s[l] - 'A']--;
                    temp[s[r] - 'A']--; // undo the increment
                    l++;
                }
            }
            return Math.Max(res, r - l);
    }
}