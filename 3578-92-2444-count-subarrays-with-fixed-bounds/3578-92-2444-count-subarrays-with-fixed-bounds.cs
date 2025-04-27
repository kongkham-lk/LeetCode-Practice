public class Solution {
    public long CountSubarrays(int[] nums, int minK, int maxK) {
        long count = 0;
        int inval = -1, min = -1, max = -1;
        Console.WriteLine(nums.Length);
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < minK || nums[i] > maxK) {
                inval = i;
                min = max = -1; // reset when found new inValid element
            }
            else {
                if (nums[i] == minK)
                    min = i;
                if (nums[i] == maxK)
                    max = i;
                if (min != -1 && max != -1)
                    count += Math.Min(min, max) - inval; // always consider invalid element on the left
            }
        }
        return count;
    }
}