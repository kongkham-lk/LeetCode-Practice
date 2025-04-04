class Solution {
    public int search(int[] nums, int target) {
        if (nums.length == 0)
            return -1;

        return searchTarget(nums, 0, nums.length - 1, target);
    }
    
    private int searchTarget(int[] nums, int l, int r, int target) {
        if (r - l <= 1)
            if (nums[l] == target)
                return l;
            else if (nums[r] == target)
                return r;
            else
                return -1;
        int foundIndex = -1;
        int mid = (r - l) / 2 + l;
        if (nums[l] == target)
            return l;
        else { // find all possible path. Break down all the left then right
            foundIndex = searchTarget(nums, l, mid, target);
            if (foundIndex == -1)
                foundIndex = searchTarget(nums, mid, r, target);
        }
        return foundIndex;
    }
}