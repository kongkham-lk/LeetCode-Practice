public class Solution {
    public int MissingNumber(int[] nums) {
        int baseSum = 0, refSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            baseSum += i;
            refSum += nums[i];
        }
        baseSum += nums.Length;

        return baseSum - refSum;
    }
}