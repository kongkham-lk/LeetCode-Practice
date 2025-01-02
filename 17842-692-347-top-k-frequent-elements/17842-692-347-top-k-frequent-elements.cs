public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int>[] memo = new List<int>[nums.Length];
            int[] res = new int[k];
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict.Add(num, 0);
            }

            foreach (var el in dict)
            {
                int c = el.Value;
                
                if (memo[c] == null)
                {
                    memo[c] = new List<int>();
                }
                memo[c].Add(el.Key);
            }
                
            int count = 0;
            for (int i = memo.Length - 1; i >= 0; i--)
            {
                if (memo[i] != null && memo[i].Any())
                    foreach (var num in memo[i])
                    {
                        if (k == count)
                            return res;
                        res[count] = num;
                        count++;
                    }
                if (k == count)
                    return res;
            }

            return res;
    }
}