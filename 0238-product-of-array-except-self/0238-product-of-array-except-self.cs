public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] results = new int[nums.Length];
        int pre = 1; // initilized the left
        results[0] = pre; // manual set the left as defualt as no left of element zero
        
        // skip first element
        for (int i = 1; i < nums.Length; i++) {
            results[i] = pre * nums[i-1]; 
            pre = results[i];
        }
        
        int pos = nums[nums.Length - 1]; // initilized the right
        
        // skip last element
        for (int i = nums.Length - 2; i >= 0; i--) {
            results[i] *= pos; // multiply the right and the left
            pos *= nums[i]; // multiply the right with current to be nex element's right
        }
        return results;
    }
}