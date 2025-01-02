public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
            Array.Sort(nums);
            List<int>[] memo = new List<int>[nums.Length];
            // int maxCount = 0;
            int prev = int.MinValue;
            int count = 0;
            int lastIndex = 0;
            int[] res = new int[k];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    prev = nums[i];
                    continue;
                }
                if (prev == nums[i])
                {
                    count++;
                }
                else
                {
                    if (memo[count] == null)
                    {
                        memo[count] = new List<int>();
                    }
                    memo[count].Add(prev);
                    prev = nums[i];
                    count = 0;
                }
            }

            if (prev != int.MinValue && count >= 0)
            {
                if (memo[count] == null || !memo[count].Any())
                    memo[count] = new List<int>();
                memo[count].Add(prev);
                count = 0;
            }

                
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