public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        string res = "";
        int w1Size = word1.Length;
        int w2Size = word2.Length;
        while (i < w1Size || i < w2Size) {
            if (i < w1Size)
                res += word1[i];
            if (i < w2Size)
                res += word2[i];
            i++;
        }

        return res;
    }
}