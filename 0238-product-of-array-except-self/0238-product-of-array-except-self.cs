public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] results = new int[nums.Length];
        int pre = 1; // initilized the left
        int pos = 1; // initilized the right
        
        for (int i = 0; i < nums.Length; i++) {
            results[i] = pre; // assign all left to an empty result list
            pre = results[i] * nums[i]; // multiply the left with current nums to be the nex element's left
        }
        
        // skip last element
        for (int i = nums.Length - 1; i >= 0; i--) {
            results[i] *= pos; // multiply the right and the left
            pos *= nums[i]; // multiply the right with current to be nex element's right
        }
        return results;
    }
}