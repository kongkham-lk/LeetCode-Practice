public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int size = nums.Length;
        for(int i = 0; i < size; i++) {
            int left = target - nums[i];
            for(int j = i + 1; j < size; j++) {
                if (left - nums[j] == 0)
                    return new int[] {i, j};
            }
        }
        return null;
    }
}