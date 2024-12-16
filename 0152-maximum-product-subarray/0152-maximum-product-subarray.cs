public class Solution {
    public int MaxProduct(int[] nums) {
        if (!nums.Any()) 
            return 0;
        else if (nums.Length == 1)
            return nums[0];
        else 
        {
            int max = nums[0];
            int min = nums[0];
            int ans = nums[0];

            for (int i = 1; i < nums.Length; i++) 
            {
                int temp = max * nums[i];

                max = Math.Max(Math.Max(temp, min * nums[i]), nums[i]); // keep track of the positive number
                min = Math.Min(Math.Min(temp, min * nums[i]), nums[i]); // keep track of the negative number

                if (ans < max)
                    ans = max;
            }
            return ans;
        }
        return 0;
    }
}