public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
            IList<IList<string>> result = new List<IList<string>>();
            IList<string> memo = new List<string>();

            foreach (string str in strs)
            {
                int[] charCountList = new int[26];
                foreach (char el in str)
                {
                    charCountList[el - 'a']++;
                }

                string charCountStr = string.Join("#", charCountList);
                if (memo.Contains(charCountStr))
                {
                    int index = memo.IndexOf(charCountStr);
                    result[index].Add(str);
                } 
                else
                {
                    IList<string> newList = new List<string>() { str };
                    result.Add(newList);
                    memo.Add(charCountStr);
                }
            }

            return result;
    }
}