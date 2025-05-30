public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double max = 0;
        for (int i = 0; i < k; i++)
            max += nums[i];

        double curr = max;
        for (int i = k; i < nums.Length; i++) {
            curr += nums[i] - nums[i-k];
            max = Math.Max(max, curr);
        }
        return max / k;
    }
}