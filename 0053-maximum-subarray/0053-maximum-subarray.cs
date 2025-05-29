public class Solution {
    public int MaxSubArray(int[] nums) {
        if (nums.Length == 1) return nums[0];

        List<int> res = new List<int>();
        int max = 0;
        for (int i = 0; i < nums.Length; i++) {
            max += nums[i];
            res.Add(max);
            if (max < 0)
                max = 0;
            // Console.WriteLine(nums[i] + ", " + max);
        }
            
        return res.Max();
    }
}