public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if (s.Length != t.Length)
            return false;
        
        char[] sStr = s.ToArray();
        char[] tStr = t.ToArray();
        
        Array.Sort(sStr);
        Array.Sort(tStr);

        for (int i = 0; i < sStr.Length; i++)
        {
            if (sStr[i] != tStr[i])
                return false;
        }

        return true;
    }
}