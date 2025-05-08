public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string res = "";
        int w1Size = word1.Length;
        int w2Size = word2.Length;
        int size = Math.Max(w1Size, w2Size);
        for (int i = 0; i < size; i++) {
            if (i < w1Size)
                res += word1[i];
            if (i < w2Size)
                res += word2[i];
        }
        return res;
    }
}