public class Solution {
    public void MoveZeroes(int[] nums) {
        int l = 0;
        int size = nums.Length;
        while (l < size) {
            if (nums[l] == 0)
                break;
            l++;
        } 
        
        int r = l + 1;
        while (l < size && r < size) {
            if (nums[l] == 0 && nums[r] != 0) {
                nums[l] = nums[r];
                nums[r] = 0;
                l++;
            }
            r++;
        }
    }
}