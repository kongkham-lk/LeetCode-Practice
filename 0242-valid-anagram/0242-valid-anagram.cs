public class Solution {
    public bool IsAnagram(string s, string t) {
            if (s.Length != t.Length)
                return false;
            
            Dictionary<char, int> sList = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
                if (sList.ContainsKey(s[i]))
                    sList[s[i]] += 1;
                else
                    sList.Add(s[i], 1);
            
            for (int i = 0; i < t.Length; i++)
                if (!sList.ContainsKey(t[i]))
                    return false;
                else
                    sList[t[i]] -= 1;

            foreach (var val in sList.Values)
                if (val != 0)
                    return false;
            
            return true;
    }
}