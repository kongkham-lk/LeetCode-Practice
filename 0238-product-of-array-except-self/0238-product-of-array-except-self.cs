public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] temp = new int[nums.Length];
        temp[0] = 1;
        int pre = nums[0];
        int pos = 1;

        for (int i = 1; i < nums.Length; i++) {
            temp[i] = pre;
            pre *= nums[i];
        }

        for (int i = nums.Length-1; i >= 0; i--) {
            temp[i] *= pos;
            pos *= nums[i];
        }
        return temp;
    }
}

//[1,-1,-1,0,0], 
//[ , , ,0,0]