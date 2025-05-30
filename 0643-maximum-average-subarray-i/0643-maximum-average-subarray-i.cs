public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        if (k == 0) return 0;
        else if (nums.Length == 1) return nums[0];
        
        int max = nums[0];
        for (int i = 1; i < k; i++)
            max += nums[i];

        int curr = max;
        for (int i = k; i < nums.Length; i++) {
            curr = curr + nums[i] - nums[i-k];
            max = Math.Max(max, curr);
        }
        return (double)max / k;
    }
}