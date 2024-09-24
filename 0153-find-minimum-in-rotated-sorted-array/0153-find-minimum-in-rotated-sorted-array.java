class Solution {
    public int findMin(int[] nums) {
        if (nums.length == 1) 
            return nums[0];
        
        int mid = (nums.length + 1) / 2;
        int l = 0;
        int r = nums.length - 1;
        int smallest = findSmallest(nums, l, r, nums[mid]);
        return smallest;
    }

    private int findSmallest(int[] nums, int l, int r, int smallest) {
        if (r <= l) {
            return smallest;
        }
        if (r - l == 1) {
            smallest = Math.min(nums[l], Math.min(smallest, nums[r]));
            return smallest;
        }
        int mid = (r - l) / 2 + l;
        smallest = Math.min(smallest, nums[mid]);
        smallest = findSmallest(nums, l, mid, smallest);
        smallest = findSmallest(nums, mid, r, smallest);
        return smallest;
    }
}