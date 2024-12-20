public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
            if (strs.Equals(""))
                return new List<IList<string>>() { new List<string>() };

            IList<IList<string>> result = new List<IList<string>>();
            IList<string> memo = new List<string>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] tempStrList = strs[i].ToArray();
                Array.Sort(tempStrList);
                string tempStr = string.Join("", tempStrList);

                if (!result.Any() || !memo.Contains(tempStr))
                {
                    IList<string> newList = new List<string>();
                    newList.Add(strs[i]);
                    result.Add(newList);
                    
                    memo.Add(tempStr);
                }
                else
                {
                    int index = memo.IndexOf(tempStr);
                    IList<string> targetList = result[index];
                    targetList.Add(strs[i]);
                }
            }

            return result;
    }
}