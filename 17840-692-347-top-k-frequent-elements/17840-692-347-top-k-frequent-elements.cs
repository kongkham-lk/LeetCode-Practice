public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> memo = new Dictionary<int, int>();
        int[] res = new int[k];
        foreach (var num in nums)
        {
            if (memo.ContainsKey(num))
                memo[num]++;
            else
                memo.Add(num, 1);
        }

        var keyList = memo.Select(x => x.Key).ToArray();
        var valueList = memo.Select(x => x.Value).ToArray();
        
        for (int i = 0; i < k; i++)
        {
            int maxEl = valueList.Max();
            int index = valueList.ToList().IndexOf(maxEl);
            valueList[index] = -1;
            res[i] = keyList[index];
        }

        return res;
    }
}