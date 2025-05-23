public class Solution {
    public int Compress(char[] chars) {
        List<char> key = new List<char>();
        List<int> val = new List<int>();

        int i = -1;
        char prev = ' ';
        foreach(char c in chars) {
            if (!prev.Equals(c)) {
                prev = c;        
                key.Add(c);
                val.Add(1);
                i++;
            } else
                val[i]++;
        }
        
        return Combine(key, val, chars);
    }

    private int Combine(List<char> key, List<int> val, char[] chars) {
        int i = 0;
        int j = 0;
        while (j < key.Count()) {
            chars[i++] = key[j];
            if (val[j] != 1)
                foreach (char d in val[j].ToString())
                    chars[i++] = d;
            j++;
        }
        return i;
    }
}