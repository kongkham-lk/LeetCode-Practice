public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Array.Sort(nums);
        int shiftPos = nums[0] < 0 ? nums[0] * -1 : 0;
        int maxSize = nums.Max() + 1 + shiftPos;
        int[] memo = new int[maxSize];
        int[] res = new int[k];
        foreach (var num in nums)
            memo[num + shiftPos]++;

        for (int i = 0; i < k; i++)
        {
            int maxEl = memo.Max();
            int index = memo.ToList().IndexOf(maxEl);
            memo[index] = 0;
            res[i] = index - shiftPos;
        }

        return res;
    }
}