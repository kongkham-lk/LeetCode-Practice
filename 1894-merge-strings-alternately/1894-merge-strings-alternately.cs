public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        string res = "";
        int w1Size = word1.Length;
        int w2Size = word2.Length;
        char[] w1 = word1.Select(c => c).ToArray();;
        char[] w2 = word2.Select(c => c).ToArray();;
        while (i < w1Size || i < w2Size) {
            if (i < w1Size)
                res += w1[i];
            if (i < w2Size)
                res += w2[i];
            i++;
        }

        return res;
    }
}