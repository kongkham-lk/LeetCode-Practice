public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> result = new List<IList<string>>();
        Dictionary<string, IList<string>> memo = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            string targetString = strs[i];
            char[] tempStrList = targetString.ToArray();
            Array.Sort(tempStrList);
            string tempStr = string.Join("", tempStrList);

            if (memo.ContainsKey(tempStr))
                memo[tempStr].Add(targetString);
            else
            {
                IList<string> newList = new List<string>();
                newList.Add(targetString);
                memo.Add(tempStr, newList);
            }
        }

        if (memo.Any())
            foreach (var resultList in memo.Values)
                result.Add(resultList);
        else
            result.Add(new List<string>() {""});

        return result;
    }
}