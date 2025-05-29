public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];
        int curr = max;
        for (int i = 1; i < nums.Length; i++) {
            int temp = nums[i];
            curr = Math.Max(temp, temp+curr);
            max = Math.Max(curr, max);
        }
            
        return max;
    }
}