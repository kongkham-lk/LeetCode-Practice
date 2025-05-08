public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        string res = "";
        while (i < word1.Length && i < word2.Length) {
            res += word1[i].ToString() + word2[i].ToString();
            i++;
        }

        while (i < word1.Length) {
            res += word1[i].ToString();
            i++;
        }
        while (i < word2.Length) {
            res += word2[i].ToString();
            i++;
        }
        return res;
    }
}