public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        if (k == 0) return 0;
        else if (nums.Length == 1) return nums[0];

        int l = 0;
        int r = 1;
        int max = nums[l];
        // Console.WriteLine(nums[l] + ": " + max);

        while (r < k) {
            max += nums[r];
            // Console.WriteLine(nums[r] + ": " + max);
            r++;
        }

        int curr = max;
        while (r < nums.Length) {
            // Console.Write(curr + " - " + nums[l] + " + " + nums[r] + " => ");
            curr = curr + nums[r] - nums[l];
            max = Math.Max(max, curr);
            l++;
            r++;
            // Console.WriteLine(curr + ", " + max);
        }
        return (double)max / k;
    }
}