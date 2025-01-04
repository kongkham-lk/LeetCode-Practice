public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (!nums.Any()) {
            return 0;
        }

        Array.Sort(nums);
        int countMax = 0;
        int tempCount = 0;
        int prev = int.MaxValue;
        foreach (int num in nums) {
            if (prev + 1 != num) {
                countMax = Math.Max(countMax, tempCount);
                if (prev != num)
                    tempCount = 1;
            } else {
                tempCount++;
            }
            prev = num;
        }
        countMax = Math.Max(countMax, tempCount);
        return countMax;
    }
}