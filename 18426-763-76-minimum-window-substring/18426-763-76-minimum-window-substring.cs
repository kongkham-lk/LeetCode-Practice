public class Solution {
    public string MinWindow(string s, string t) {
            Dictionary<char, int> haveMemo = new Dictionary<char, int>();
            Dictionary<char, int> needMemo = new Dictionary<char, int>();
            foreach (var c in t)
            {
                if (needMemo.ContainsKey(c))
                    needMemo[c]++;
                else
                    needMemo[c] = 1;
            }

            int have = 0, need = needMemo.Count;
            int l = 0, r = 0;
            int[] res = {-1, -1};
            int resLen = Int32.MaxValue;
            for (r = 0; r < s.Length; r++)
            {
                char c = s[r];
                if (haveMemo.ContainsKey(c))
                    haveMemo[c]++;
                else
                    haveMemo[c] = 1;

                if (needMemo.ContainsKey(c) && haveMemo[c] == needMemo[c])
                    have++;
                
                while (have == need)
                {
                    if (resLen > (r - l + 1))
                    {
                        res = new int[]{l, r};
                        resLen = (r - l + 1);
                    }

                    haveMemo[s[l]]--;
                    if (needMemo.ContainsKey(s[l]) && haveMemo[s[l]] < needMemo[s[l]])
                        have--;
                    l++;
                }
            }

            l = res[0];
            r = res[1];
            return resLen != Int32.MaxValue ? s.Substring(l, r - l + 1) : "";
    }
}